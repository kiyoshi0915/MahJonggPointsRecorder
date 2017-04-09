//*********************************
//  麻雀点数記録装置
//  214/08/14 Ver.1.0.0 初版
//*********************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Web;
using System.Web.UI.WebControls;

namespace 麻雀点数記録装置
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "定数"
        public const int NUM_OF_MEMBAR = 4;  //メンバー数     
        public const int FIRST_PT = 25000;   //初期持ち点
        public const int REACHBAR_PT = 1000; //リー棒点数
        public const int SYUKUGI_PT = 100;   //祝儀点
        private const string REACH = "リーチ";
        private const string REACH_CNL = "リーチキャンセル";
        private Font REACH_FONT = new Font("MS UI Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(128)));
        private Font REACH_CNL_FONT = new Font("MS UI Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(128)));
        //メッセージ
        private const string MSG_GET_FAIL = "ScoreBook.xls内の対象セルが見つかりませんでした。";
        private const string MSG_TITLE_GET_FAIL = "対象セル取得エラー";
        private const string MSG_GET_PT_ZERO = "ScoreBook.xlsのこの飜数・符数での設定点数が０ですが、\nよろしいですか？";
        private const string MSG_TITLE_PT_ZERO = "点数取得値エラー";
        //便宜用
        private const int CONST_1 = 1;
        private const int CONST_M1 = -1;
        private const int CONST_M2 = -2;
        //ファン
        public enum en_Fan
        {
            ton = 0,
            nan = 1,
            sya = 2,
            pe = 3
        }
        #endregion

        #region "メンバ・アクセサ"
        //ゲーム・画面情報
        public struct Info
        {
            public int[] arr_point;     //各プレイヤー持ち点
            public int kyoku;           //局
            public int honba;           //本場
            public int reachBar;        //リー棒
            public bool isGameEnd;      //ゲーム終了フラグ
            public int oya;             //親
            public bool[] arr_canReach; //リーチ可否フラグ
            public int rdoAgari;        //上がりの人
            public int rdoHoju;         //放銃した人
            public int fan;             //ファン数
            public int fu;              //符数
            public bool canCalc;        //計算可否の状態
            public bool canPrev;        //戻れる状態
            public bool canNext;        //進める状態
            public int prevWhoPt;       //前回の上がり人の合計点     
            public int prevFromMainPot; //前回の放銃者orツモ上がられ時の親の点
            public int prevFromKoPt;    //ツモ上がられ時の子
            public int prevOya;         //前回の親
            public int prevReachBarPt;  //リー棒点
            public int prevSyukugiPt;   //祝儀点

            // コンストラクタ 
            public Info(int n)
            {
                arr_point = new int[4] { n, n, n, n };
                kyoku = 0;
                honba = 0;
                reachBar = 0;
                isGameEnd = false;
                oya = (int)en_Fan.ton;
                arr_canReach = new bool[4] { true, true, true, true };
                rdoAgari = (int)en_Fan.ton;
                rdoHoju = (int)en_Fan.ton;
                fan = 2;
                fu = 20;
                canCalc = true;
                canPrev = false;
                canNext = false;
                prevWhoPt = CONST_M1;
                prevFromMainPot = -1;
                prevFromKoPt = -1;
                prevOya = -1;
                prevReachBarPt = CONST_M1;
                prevSyukugiPt = CONST_M1;
            }
            public Info DeepCopy()
            {
                Info cloneObject = (Info)this.Clone();

                if (this.arr_point != null)
                {
                    cloneObject.arr_point = (int[])this.arr_point.Clone();
                }
                if (arr_canReach != null)
                {
                    cloneObject.arr_canReach = (bool[])this.arr_canReach.Clone();
                }
                return cloneObject;
            }

            private Object Clone()
            {
                return this.MemberwiseClone();
            }
        }
        private Info m_info;    //ゲーム・画面情報インスタンス
        public Info M_info { get { return m_info; } set { this.m_info = value; } }
        public void setInfo_ReachBar(int intReachBar) { this.m_info.reachBar = intReachBar; }
        public void setInfo_Kyoku(int intKyoku) { this.m_info.kyoku = intKyoku; }
        public void setInfo_Oya(int intOya) { this.m_info.oya = intOya; }
        public void setInfo_Honba(int intReachBar) { this.m_info.honba = intReachBar; }

        private Score m_scr;      //スコアインスタンス
        private Dictionary<int, Info> m_dicInfo; //ゲーム・画面情報履歴
        private int m_currentIdx; //現在のインデックス
        private int m_latestIdx;  //直近のインデックス

        //子画面フォーム
        public Form2 f2;
        #endregion

        #region "ロード処理"
        //画面ロード
        private void Form1_Load(object sender, EventArgs e)
        {
            //変数初期化
            m_info = new Info(FIRST_PT);
            m_scr = new Score();
            m_dicInfo = new Dictionary<int, Info>();
            m_currentIdx = -1; //setDispInfoで加算され、0に。
            m_latestIdx = -1;

            //画面初期表示
            setDispInfo(m_info);

            //ドロップダウンリスト設定
            //ファン数
            this.drpFan.Items.Clear();
            this.drpFan.Items.Add(new ListItem("１飜", "1"));
            this.drpFan.Items.Add(new ListItem("２飜", "2"));
            this.drpFan.Items.Add(new ListItem("３飜", "3"));
            this.drpFan.Items.Add(new ListItem("４飜", "4"));
            this.drpFan.Items.Add(new ListItem("５飜", "5"));
            this.drpFan.Items.Add(new ListItem("６～７飜", "6"));
            this.drpFan.Items.Add(new ListItem("８～１０飜", "8"));
            this.drpFan.Items.Add(new ListItem("１１～１２飜", "11"));
            this.drpFan.Items.Add(new ListItem("１３飜以上", "13"));
            this.drpFan.SelectedIndex = 0;
            //符数
            this.drpFu.Items.Clear();
            this.drpFu.Items.Add(new ListItem("２０符", "20"));
            this.drpFu.Items.Add(new ListItem("２５符(七対子:２飜)", "25"));
            this.drpFu.Items.Add(new ListItem("３０符", "30"));
            this.drpFu.Items.Add(new ListItem("４０符", "40"));
            this.drpFu.Items.Add(new ListItem("５０符", "50"));
            this.drpFu.Items.Add(new ListItem("６０符", "60"));
            this.drpFu.Items.Add(new ListItem("７０符", "70"));
            this.drpFu.SelectedIndex = 0;

            //イベントハンドラ
            this.btnP1_Reach.Click += new EventHandler(btnReach_Click);
            this.btnP2_Reach.Click += new EventHandler(btnReach_Click);
            this.btnP3_Reach.Click += new EventHandler(btnReach_Click);
            this.btnP4_Reach.Click += new EventHandler(btnReach_Click);
            this.rdoP1_Agari.CheckedChanged += new EventHandler(rdoHoju_Changed);
            this.rdoP2_Agari.CheckedChanged += new EventHandler(rdoHoju_Changed);
            this.rdoP3_Agari.CheckedChanged += new EventHandler(rdoHoju_Changed);
            this.rdoP4_Agari.CheckedChanged += new EventHandler(rdoHoju_Changed);
            this.btnNext.Click += new EventHandler(btnMove_Click);
            this.btnPrev.Click += new EventHandler(btnMove_Click);
        }
        #endregion

        #region "画面・ゲーム情報処理"
        //画面情報取得
        private void getDispInfo()
        {
            m_info.arr_canReach[(int)en_Fan.ton] = (this.btnP1_Reach.Text == REACH);
            m_info.arr_canReach[(int)en_Fan.nan] = (this.btnP2_Reach.Text == REACH);
            m_info.arr_canReach[(int)en_Fan.sya] = (this.btnP3_Reach.Text == REACH);
            m_info.arr_canReach[(int)en_Fan.pe] = (this.btnP4_Reach.Text == REACH);
            m_info.rdoAgari = this.rdoP1_Agari.Checked ? (int)en_Fan.ton :
                              this.rdoP2_Agari.Checked ? (int)en_Fan.nan :
                              this.rdoP3_Agari.Checked ? (int)en_Fan.sya :
                              this.rdoP4_Agari.Checked ? (int)en_Fan.pe : -1;
            m_info.rdoHoju = this.rdoP1_Hoju.Checked ? (int)en_Fan.ton :
                             this.rdoP2_Hoju.Checked ? (int)en_Fan.nan :
                             this.rdoP3_Hoju.Checked ? (int)en_Fan.sya :
                             this.rdoP4_Hoju.Checked ? (int)en_Fan.pe : -1;
            m_info.fan = int.Parse(((ListItem)this.drpFan.SelectedItem).Value.ToString());
            m_info.fu = int.Parse(((ListItem)this.drpFu.SelectedItem).Value.ToString());
        }

        //ゲーム情報更新
        private int updInfo(ref Info info, bool isRyukyoku = false)
        {
            if (!isRyukyoku)
            {
                //親が上がった場合
                if (info.rdoAgari == info.oya)
                {
                    info.honba++; //本場
                }
                //子が上がった場合    
                else
                {
                    info.kyoku++;    //局
                    //南四局終了でゲーム終了
                    if (info.kyoku > 7) { return CONST_1; }
                    info.honba = 0; //本場
                    info.oya = ++info.oya % NUM_OF_MEMBAR;  //親移動
                }
            }
            else
            {
                //流局
                info.kyoku++; //局
                //南四局終了でゲーム終了
                if (info.kyoku > 7) { return CONST_1; }
                info.honba++; //本場
                info.oya = ++info.oya % NUM_OF_MEMBAR;  //親移動
            }

            //リーチ可否
            for (int i = 0; i < NUM_OF_MEMBAR; i++)
                info.arr_canReach[i] = (info.arr_point[i] >= REACHBAR_PT) ? true : false;
            //戻る・進むボタン使用可否
            info.canNext = false;
            info.canPrev = true;

            return 0;
        }

        //画面情報セット
        public void p_setDispInfo(Info info, bool isSave = true, bool isRdoMv = true)
        {
            setDispInfo(info, isSave, isRdoMv);
        }
        private void setDispInfo(Info info, bool isSave = true, bool isRdoMv = true)
        {
            this.lblKyoku.Text = info.kyoku == 0 ? "東一局" :
                                 info.kyoku == 1 ? "東二局" :
                                 info.kyoku == 2 ? "東三局" :
                                 info.kyoku == 3 ? "東四局" :
                                 info.kyoku == 4 ? "南一局" :
                                 info.kyoku == 5 ? "南二局" :
                                 info.kyoku == 6 ? "南三局" :
                                 info.kyoku == 7 ? "南四局" : "";
            this.lblHonba.Text = Strings.StrConv(info.honba.ToString(), VbStrConv.Wide, 0) + "本場";
            this.lblReachBar.Text = Strings.StrConv(info.reachBar.ToString(), VbStrConv.Wide, 0) + "本";

            this.lblGameEnd.Visible = info.isGameEnd;

            this.lblP1_Oya.Visible = (info.oya == (int)en_Fan.ton);
            this.lblP2_Oya.Visible = (info.oya == (int)en_Fan.nan);
            this.lblP3_Oya.Visible = (info.oya == (int)en_Fan.sya);
            this.lblP4_Oya.Visible = (info.oya == (int)en_Fan.pe);

            this.txtP1_Point.Text = info.arr_point[(int)en_Fan.ton].ToString();
            this.txtP2_Point.Text = info.arr_point[(int)en_Fan.nan].ToString();
            this.txtP3_Point.Text = info.arr_point[(int)en_Fan.sya].ToString();
            this.txtP4_Point.Text = info.arr_point[(int)en_Fan.pe].ToString();

            int[] arrFan = new int[] { (int)en_Fan.ton, (int)en_Fan.nan, (int)en_Fan.sya, (int)en_Fan.pe };
            System.Windows.Forms.Button[] arrBtnReach = new System.Windows.Forms.Button[] { this.btnP1_Reach, this.btnP2_Reach, this.btnP3_Reach, this.btnP4_Reach };
            for (int i = 0; i <= (int)en_Fan.pe; i++)
            {
                if (info.arr_point[arrFan[i]] < REACHBAR_PT)
                {
                    chgFontReachBtn(arrBtnReach[i], true);
                    arrBtnReach[i].Enabled = false;
                }
                else
                {
                    if (info.arr_canReach[arrFan[i]]) chgFontReachBtn(arrBtnReach[i], true);
                    else chgFontReachBtn(arrBtnReach[i], false);
                }
            }

            if (isRdoMv)
            {
                if (info.rdoAgari == (int)en_Fan.ton) this.rdoP1_Agari.Checked = true;
                else if (info.rdoAgari == (int)en_Fan.nan) this.rdoP2_Agari.Checked = true;
                else if (info.rdoAgari == (int)en_Fan.sya) this.rdoP3_Agari.Checked = true;
                else if (info.rdoAgari == (int)en_Fan.pe) this.rdoP4_Agari.Checked = true;

                if (info.rdoHoju == (int)en_Fan.ton) this.rdoP1_Hoju.Checked = true;
                else if (info.rdoHoju == (int)en_Fan.nan) this.rdoP2_Hoju.Checked = true;
                else if (info.rdoHoju == (int)en_Fan.sya) this.rdoP3_Hoju.Checked = true;
                else if (info.rdoHoju == (int)en_Fan.pe) this.rdoP4_Hoju.Checked = true;
            }

            this.btnCalc.Enabled = info.canCalc;

            if (info.prevWhoPt == CONST_M1)
            {
                this.lblPrevWho.Text = "";
                this.lblPrevWho_PointSum.Text = "合計   - - - 点";
                this.lblPrevFromMain.Text = "";
                this.lblPrevFromMain_Point.Text = " - - - 点";
                this.lblPrevFromKo.Text = "";
                this.lblPrevFromKo_Point.Text = " - - - 点";
            }
            else if (info.prevWhoPt == CONST_M2)
            {
                this.lblPrevWho.Text = "流局";
                this.lblPrevWho_PointSum.Text = "   - - - 点";
                this.lblPrevFromMain.Text = "";
                this.lblPrevFromMain_Point.Text = " - - - 点";
                this.lblPrevFromKo.Text = "";
                this.lblPrevFromKo_Point.Text = " - - - 点";
            }
            else
            {
                this.lblPrevWho.Text = (info.rdoAgari == (int)en_Fan.ton) ? "東が" :
                                       (info.rdoAgari == (int)en_Fan.nan) ? "南が" :
                                       (info.rdoAgari == (int)en_Fan.sya) ? "西が" :
                                       (info.rdoAgari == (int)en_Fan.pe) ? "北が" : "";
                this.lblPrevWho_PointSum.Text = "合計  " + Strings.StrConv(info.prevWhoPt.ToString(), VbStrConv.Wide, 0) + "点";

                if (info.rdoAgari != info.rdoHoju)
                {
                    this.lblPrevFromMain.Text = (info.rdoHoju == (int)en_Fan.ton) ? "東から" :
                                                (info.rdoHoju == (int)en_Fan.nan) ? "南から" :
                                                (info.rdoHoju == (int)en_Fan.sya) ? "西から" :
                                                (info.rdoHoju == (int)en_Fan.pe) ? "北から" : "";
                    this.lblPrevFromMain_Point.Text = Strings.StrConv(info.prevFromMainPot.ToString(), VbStrConv.Wide, 0) + "点";

                    this.lblPrevFromKo.Text = "";
                    this.lblPrevFromKo_Point.Text = "";
                }
                else
                {
                    //前回の親かどうかで判断
                    if (info.rdoAgari == info.prevOya)
                    {
                        this.lblPrevFromMain.Text = "オール";
                        this.lblPrevFromMain_Point.Text = Strings.StrConv(info.prevFromMainPot.ToString(), VbStrConv.Wide, 0) + "点";

                        this.lblPrevFromKo.Text = "";
                        this.lblPrevFromKo_Point.Text = "";
                    }
                    else
                    {
                        this.lblPrevFromMain.Text = (info.prevOya == (int)en_Fan.ton) ? "東（親）から" :
                                                    (info.prevOya == (int)en_Fan.nan) ? "南（親）から" :
                                                    (info.prevOya == (int)en_Fan.sya) ? "西（親）から" :
                                                    (info.prevOya == (int)en_Fan.pe) ? "北（親）から" : "";
                        this.lblPrevFromMain_Point.Text = Strings.StrConv(info.prevFromMainPot.ToString(), VbStrConv.Wide, 0) + "点";

                        this.lblPrevFromKo.Text = "子から";
                        this.lblPrevFromKo_Point.Text = Strings.StrConv(info.prevFromKoPt.ToString(), VbStrConv.Wide, 0) + "点";
                    }
                }
            }
            this.lblPrevReachBarPoint.Text = (info.prevReachBarPt != CONST_M1) ?
                Strings.StrConv(info.prevReachBarPt.ToString(), VbStrConv.Wide, 0) + "点" : " - - - 点";
            this.lblPrevSyukugiPoint.Text = (info.prevSyukugiPt != CONST_M1) ?
                Strings.StrConv(info.prevSyukugiPt.ToString(), VbStrConv.Wide, 0) + "点）" : " - - - 点）";

            this.btnNext.Enabled = info.canNext;
            this.btnPrev.Enabled = info.canPrev;

            //ゲーム・画面情報履歴保存
            if (isSave)
            {
                //現在以降の履歴消去
                for (int i = m_dicInfo.Count; i > m_currentIdx; i--)
                    m_dicInfo.Remove(i);
                //履歴追加
                m_dicInfo.Add(++m_currentIdx, m_info.DeepCopy());
                m_latestIdx = m_currentIdx;
            }
            this.lblGameIdx.Text = Strings.StrConv((m_currentIdx + 1).ToString(), VbStrConv.Wide, 0) + "戦目";
        }
        #endregion

        #region "計算ボタン押下"
        //計算ボタン押下
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int wkInt;
            try
            {
                //画面情報取得
                this.getDispInfo();

                //点数計算
                wkInt = this.calcPoint(ref m_info);
                if (wkInt == CONST_1)
                {
                    return;
                }
                //ゲーム情報更新
                wkInt = this.updInfo(ref m_info);
                if (wkInt == CONST_1)
                {
                    //ゲーム終了時
                    m_info.isGameEnd = true;
                    m_info.canCalc = false;
                }

                //画面再描写
                this.setDispInfo(m_info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //点数計算
        private int calcPoint(ref Info info)
        {
            int intRtn;
            bool isResSend = false;

            //前回得点のクリア
            info.prevWhoPt = 0;
            info.prevFromMainPot = 0;
            info.prevFromKoPt = 0;
            info.prevReachBarPt = 0;
            info.prevSyukugiPt = 0;

            //親の記録
            info.prevOya = info.oya;

            //ツモ
            if (info.rdoAgari == info.rdoHoju)
            {
                for (int i = 0; i < NUM_OF_MEMBAR; i++)
                {
                    //上がりの人以外から徴収
                    if (i != info.rdoAgari)
                    {
                        //譲渡点数計算
                        int wkPoint = 0;
                        //上がりの点数
                        intRtn = m_scr.getScore(true,
                                                info.rdoAgari == info.oya,
                                                i == info.oya,
                                                info.fan,
                                                info.fu,
                                                ref wkPoint);
                        if (intRtn != 0)
                        {
                            //セル取得失敗エラー
                            if (intRtn == Score.ERR_GET_FAIL)
                            {
                                DialogResult dlgRlt = MessageBox.Show(MSG_GET_FAIL, MSG_TITLE_GET_FAIL, MessageBoxButtons.OK);
                                return CONST_1;
                            }
                            //取得値がゼロの場合
                            if (!isResSend && intRtn == Score.ERR_GET_ZERO)
                            {
                                DialogResult dlgRlt = MessageBox.Show(MSG_GET_PT_ZERO, MSG_TITLE_PT_ZERO, MessageBoxButtons.YesNo);
                                isResSend = true;
                                if (dlgRlt == DialogResult.No) return CONST_1;
                            }
                        }
                        //ご祝義点
                        wkPoint += info.honba * SYUKUGI_PT;
                        info.prevSyukugiPt += info.honba * SYUKUGI_PT;

                        //上がった人の加算
                        info.arr_point[info.rdoAgari] += wkPoint;
                        info.prevWhoPt += wkPoint;
                        //徴収された人の減算
                        info.arr_point[i] -= wkPoint;
                        if (info.rdoAgari == info.oya)
                        {
                            //上がった人が親
                            info.prevFromMainPot = wkPoint;
                            info.prevFromKoPt = -1;
                        }
                        else
                        {
                            //上がった人が子
                            if (i == info.oya) info.prevFromMainPot = wkPoint;
                            else info.prevFromKoPt = wkPoint;
                        }
                    }
                }
            }
            //ロン
            else
            {
                //譲渡点数計算
                int wkPoint = 0;
                intRtn = m_scr.getScore(false,
                                        info.rdoAgari == info.oya,
                                        false,
                                        info.fan,
                                        info.fu,
                                        ref wkPoint);
                if (intRtn != 0)
                {
                    //セル取得失敗エラー
                    if (intRtn == Score.ERR_GET_FAIL)
                    {
                        DialogResult dlgRlt = MessageBox.Show(MSG_GET_FAIL, MSG_TITLE_GET_FAIL, MessageBoxButtons.OK);
                        return CONST_1;
                    }
                    //取得値がゼロの場合
                    if (!isResSend && intRtn == Score.ERR_GET_ZERO)
                    {
                        DialogResult dlgRlt = MessageBox.Show(MSG_GET_PT_ZERO, MSG_TITLE_PT_ZERO, MessageBoxButtons.YesNo);
                        isResSend = true;
                        if (dlgRlt == DialogResult.No) return CONST_1;
                    }
                }
                //ご祝義点
                wkPoint += info.honba * SYUKUGI_PT * (NUM_OF_MEMBAR - 1);
                info.prevSyukugiPt += info.honba * SYUKUGI_PT * (NUM_OF_MEMBAR - 1);

                //上がった人の加算
                info.arr_point[info.rdoAgari] += wkPoint;
                info.prevWhoPt += wkPoint;
                //徴収された人の減算
                info.arr_point[info.rdoHoju] -= wkPoint;
                info.prevFromMainPot = wkPoint;
            }
            //リー棒加算
            info.arr_point[info.rdoAgari] += info.reachBar * REACHBAR_PT;
            info.prevWhoPt += info.reachBar * REACHBAR_PT;
            info.prevReachBarPt += info.reachBar * REACHBAR_PT;
            info.reachBar = 0;

            return 0;
        }
        #endregion

        #region "リーチボタン押下"
        //リーチボタン押下
        private void btnReach_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            //持ち点計算＆リーチボタン押下可否
            int wkInt = 0;
            foreach (string lpStr
             in new string[] { this.btnP1_Reach.Name, this.btnP2_Reach.Name, this.btnP3_Reach.Name, this.btnP4_Reach.Name })
            {
                //押されたボタンに対して処理
                if (btn.Name == lpStr)
                {
                    //リーチをかける
                    if (btn.Text == REACH)
                    {
                        m_info.arr_point[wkInt] -= REACHBAR_PT;
                        m_info.arr_canReach[wkInt] = false;
                        m_info.reachBar += 1; //リー棒計算
                    }
                    else
                    {
                        //リーチをキャンセル
                        m_info.arr_point[wkInt] += REACHBAR_PT;
                        m_info.arr_canReach[wkInt] = true;
                        m_info.reachBar -= 1;  //リー棒計算
                    }
                    break;
                }
                wkInt++;
            }

            //４人リーチ
            if (m_info.arr_canReach.All((x) => x == false))
            {
                //流局
                m_info.prevWhoPt = CONST_M2;
                for (int i = 0; i < NUM_OF_MEMBAR; i++) m_info.arr_canReach[i] = true;
                wkInt = updInfo(ref m_info, true);
                if (wkInt == 1)
                {
                    //ゲーム終了時
                    m_info.isGameEnd = true;
                    m_info.canCalc = false;
                }
                //画面描写(Saveあり)
                this.setDispInfo(m_info, true, false);
            }
            else
            {
                //画面描写(Saveなし)
                this.setDispInfo(m_info, false, false);
            }
            return;
        }

        //リーチボタンフォント操作
        private void chgFontReachBtn(System.Windows.Forms.Button btn, bool toReach)
        {
            if (toReach)
            {
                //リーチボタンへ
                btn.Text = REACH;
                btn.ForeColor = Color.Black;
                btn.Font = REACH_FONT;
            }
            else
            {
                //リーチキャンセルボタンへ
                btn.Text = REACH_CNL;
                btn.ForeColor = Color.Blue;
                btn.Font = REACH_CNL_FONT;
            }
        }
        #endregion

        #region "ツモ、ロン対象ラジオボタン変更"
        //ツモ、ロン対象ラジオボタン変更
        private void rdoHoju_Changed(object sender, EventArgs e)
        {
            string strFormName = ((System.Windows.Forms.RadioButton)sender).Name;
            this.rdoP1_Hoju.Text = (strFormName == this.rdoP1_Agari.Name) ? "ツモ" : "東から";
            this.rdoP2_Hoju.Text = (strFormName == this.rdoP2_Agari.Name) ? "ツモ" : "南から";
            this.rdoP3_Hoju.Text = (strFormName == this.rdoP3_Agari.Name) ? "ツモ" : "西から";
            this.rdoP4_Hoju.Text = (strFormName == this.rdoP4_Agari.Name) ? "ツモ" : "北から";
            return;
        }
        #endregion

        #region "戻る、進むボタン押下"
        //戻る、進むボタン押下
        private void btnMove_Click(object sender, EventArgs e)
        {
            this.mvInfo(((System.Windows.Forms.Button)sender).Name == this.btnNext.Name ? 1 : -1);
        }

        //ゲーム・画面履歴操作
        private void mvInfo(int move)
        {
            //現在のIdxから 履歴最初期、履歴最新を超えることはできない
            if (m_currentIdx + move < 0) return;
            if (m_currentIdx + move > m_latestIdx) return;

            //ゲーム・画面情報を動かす
            m_info = m_dicInfo[(m_currentIdx += move)];
            m_info.canNext = (m_currentIdx < m_latestIdx) ? true : false;
            m_info.canPrev = (m_currentIdx != 0) ? true : false;

            //画面表示
            setDispInfo(m_info, false);
        }

        #endregion

        #region "点数修正ボタン押下"
        //点数修正ボタン押下
        private void btnPointFix_Click(object sender, EventArgs e)
        {
            if (f2 != null && !f2.IsDisposed)
            {
                f2.Focus();
                return;
            }
            f2 = new Form2();
            f2.f1 = this;
            f2.Show();
            return;
        }
        #endregion


        #region "テスト関係"
        //テスト用ボタン
        private void btnTest_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.f1 = this;
            return;
        }
        #endregion
    }
}
