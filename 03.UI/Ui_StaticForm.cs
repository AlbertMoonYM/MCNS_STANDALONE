using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using MCNS_STANDALONE._03.UI;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MCNS_STANDALONE
{
    public static class Ui_StaticForm
    {
        public static FormInitialPage formInitialPage {  get; set; } = new FormInitialPage();
        public static FormConceptSheet formConceptSheet { get; set; }
        public static FormConfigPage formConfigPage { get; set; }
        public static FormIoList formIoList { get; set; }
        public static FormItemsList formItemsList { get; set; }
        public static XtraReport1 xtraReport1 {  get; set; }

    }
}
