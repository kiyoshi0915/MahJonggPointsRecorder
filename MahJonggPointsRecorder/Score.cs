using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace 麻雀点数記録装置
{
    class Score
    {
        //スコアブック相対パス
        private const string SCOREBOOK_NAME = "ScoreBook.xls";
        //シート名
        private struct SHT_NAME
        {
            public string dummy;
            public const string T_OYA_KO = "ツモ（親上、子支払）";  //ツモ上がり、親上がり、子の支払い
            public const string T_KO_OYA = "ツモ（子上、親支払）";  //ツモ上がり、子上がり、親の支払い
            public const string T_KO_KO = "ツモ（子上、子支払）";   //ツモ上がり、子上がり、子の支払い
            public const string R_OYA = "ロン（親上）";             //ロン上がり、親上がり
            public const string R_KO = "ロン（子上）";              //ロン上がり、子上がり
        }

        public const int ERR_GET_FAIL = 1; //セル取得失敗エラー
        public const int ERR_GET_ZERO = 2; //取得値ゼロエラー
                
        //点数取得
        /// <summary>
        /// 点数表に基づいて点数を取得
        /// </summary>
        /// <param name="isTumo">ツモorロン</param>
        /// <param name="isAgariOya">上がった人が親or子</param>
        /// <param name="isMeOya">(ツモ時)自分が親or子</param>
        /// <param name="fan">ファン数</param>
        /// <param name="fu">符数</param>
        /// <returns></returns>
        public int getScore(bool isTumo, bool isAgariOya, bool isMeOya, int fan, int fu,ref int rtnPoint)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = null;
            Workbook wb = null;

            try
            {
                //スコアブックを開く
                string ExcelBookFileName = System.Windows.Forms.Application.StartupPath + @"\" + SCOREBOOK_NAME;
                ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Visible = false;
                wb = ExcelApp.Workbooks.Open(ExcelBookFileName,
                  Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                  Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                  Type.Missing);

                //シートを開く
                Worksheet ws1;
                string wkShtName = "";
                //ツモ
                if (isTumo)
                {
                    //上がった人が親
                    if (isAgariOya) { wkShtName = SHT_NAME.T_OYA_KO; }
                    //上がった人が親
                    else
                    {
                        //自分が親
                        if (isMeOya) { wkShtName = SHT_NAME.T_KO_OYA; }
                        //自分が子
                        else { wkShtName = SHT_NAME.T_KO_KO; }
                    }
                }
                //ロン
                else
                {
                    //上がった人が親or子
                    if (isAgariOya) { wkShtName = SHT_NAME.R_OYA; }
                    else { wkShtName = SHT_NAME.R_KO; }
                }

                //シート選択
                ws1 = wb.Sheets[getSheetIndex(wkShtName, wb)];
                ws1.Select(Type.Missing);

                //セル選択
                Range range = ExcelApp.get_Range("A1", Type.Missing).CurrentRegion;
                
                //ファン数 >= 5 のとき符数固定
                if (fan >= 5) fu = 20;
                //ファン数 >= 5 のときファン数指定
                if (fan >= 5)
                {
                    if (fan == 5) fan = 5;
                    else if (fan < 8) fan = 6;
                    else if (fan < 11) fan = 8;
                    else if (fan < 13) fan = 11;
                    else fan = 13;
                }
                //列インデックス（ファン数）
                Range colRange;
                colRange = range.Find(fan.ToString(), Type.Missing,
                                        XlFindLookIn.xlValues, XlLookAt.xlPart,
                                        XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false,
                                        Type.Missing, Type.Missing);
                //行インデックス（符数）
                Range rowRange;
                rowRange = range.Find(fu.ToString(), Type.Missing,
                            XlFindLookIn.xlValues, XlLookAt.xlPart,
                            XlSearchOrder.xlByColumns, XlSearchDirection.xlNext, false,
                            Type.Missing, Type.Missing);
                //対象セル取得
                range = ExcelApp.Cells[rowRange.Row, colRange.Column];
                //対象セル取得失敗時はエラー
                if (range == null) { return ERR_GET_FAIL; }

                if (range != null)
                {
                    //取得値が0の場合はエラー
                    if ((int)(range.Value) == 0) { return ERR_GET_ZERO; }

                    rtnPoint =  (int)(range.Value);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (wb != null) wb.Close(false, Type.Missing, Type.Missing);
                if (ExcelApp != null) ExcelApp.Quit();
            }
            return 0;
        }

        //シート名から：アクセスインデックスを探し出す
        private int getSheetIndex(string sheetName, Workbook wb)
        {
            int i = 0;
            foreach (Worksheet sh in wb.Sheets)
            {
                if (sheetName == sh.Name)
                {
                    return i + 1;
                }
                i += 1;
            }
            return -1;
        }
    }
}
