using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 麻雀点数記録装置
{
    public partial class Form2 : Form
    {
        public Form1 f1;

        private const int MOTITEN_INI_SUM = Form1.FIRST_PT * Form1.NUM_OF_MEMBAR; //初期持ち点合計
        private List<Control> listControl; //コントロールリスト
        private List<GroupBox> listGrpBox; //グループボックスリスト
        private List<Button> listBtn;      //ボタンリスト

        public Form2()
        {
            InitializeComponent();
        }

        //フォームロード
        private void Form2_Load(object sender, EventArgs e)
        {
            listGrpBox = new List<GroupBox>();
            listBtn = new List<Button>();

            try
            {
                //点数差表示
                dispPtSumDiff();

                //全コントロール取得
                listControl = getAllControls(this);
                //グループボックスリスト設定
                foreach (Control lpCtrl in listControl)
                {
                    if (lpCtrl.GetType() == typeof(GroupBox))
                    {
                        listGrpBox.Add((GroupBox)lpCtrl);
                    }
                }
                //イベントハンドラ設定
                listControl.FindAll(x => x.GetType() == typeof(Button))
                           .ForEach(x => x.Click += new EventHandler(btnPointFix_Click));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private List<Control> getAllControls(Control top)
        {
            List<Control> buf = new List<Control>();
            foreach (Control c in top.Controls)
            {
                buf.Add(c);
                buf.AddRange(getAllControls(c));
            }
            return buf;
        }

        //点数修正ボタンクリック
        private void btnPointFix_Click(object sender, EventArgs e)
        {
            try
            {
                //どのグループに属しているか
                string strGrpName = listGrpBox.Find(x => x.Controls.Contains((Button)sender)).Text;
                //増減点数
                int intMovePoint = int.Parse(((Button)sender).Text);

                //点数調整
                switch (strGrpName)
                {
                    case "東":
                        f1.M_info.arr_point[(int)Form1.en_Fan.ton] += intMovePoint;
                        break;
                    case "南":
                        f1.M_info.arr_point[(int)Form1.en_Fan.nan] += intMovePoint;
                        break;
                    case "西":
                        f1.M_info.arr_point[(int)Form1.en_Fan.sya] += intMovePoint;
                        break;
                    case "北":
                        f1.M_info.arr_point[(int)Form1.en_Fan.pe] += intMovePoint;
                        break;
                    case "リー棒":
                        if (f1.M_info.reachBar + intMovePoint < 0) break;
                        f1.setInfo_ReachBar(f1.M_info.reachBar + intMovePoint);
                        break;
                    case "本場":
                        if (f1.M_info.honba + intMovePoint < 0) break;
                        f1.setInfo_Honba(f1.M_info.honba + intMovePoint);
                        break;
                    case "局":
                        if (f1.M_info.kyoku + intMovePoint < 0 || f1.M_info.kyoku + intMovePoint > 7) break;
                        f1.setInfo_Kyoku(f1.M_info.kyoku + intMovePoint);
                        if ((f1.M_info.oya + intMovePoint) > 0)
                        {
                            f1.setInfo_Oya((f1.M_info.oya + intMovePoint) % Form1.NUM_OF_MEMBAR);
                        }
                        else
                        {
                            f1.setInfo_Oya(((f1.M_info.oya + intMovePoint) + Form1.NUM_OF_MEMBAR) % Form1.NUM_OF_MEMBAR);
                        }
                        break;
                }

                //点数差表示
                dispPtSumDiff();

                //親画面描写
                f1.p_setDispInfo(f1.M_info, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        //場の点数合計と初期持ち点合計との差表示
        private void dispPtSumDiff()
        {
            int intSum = 0;
            intSum += f1.M_info.arr_point.Sum();
            intSum += f1.M_info.reachBar * Form1.REACHBAR_PT;
            int intDiff = intSum - (Form1.FIRST_PT * Form1.NUM_OF_MEMBAR);
            this.txtPointDiff.Text = (intDiff > 0) ? "＋" + intDiff.ToString() : intDiff.ToString();
        }

    }
}
