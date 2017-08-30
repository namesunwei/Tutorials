using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo02_Strategy_SimpleFactory.BaseClass;
using Demo02_Strategy_SimpleFactory.ContextClass;
using Demo02_Strategy_SimpleFactory.DerivedClass;
using Demo02_Strategy_SimpleFactory.FactoryClass;

namespace Demo02_Strategy_SimpleFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "满300返100" });
            cbxType.SelectedIndex = 0;
        }

        private double _total;

        #region 版本1--简单工厂模式
        //private void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    var csuper = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString().Trim());
        //    var totalPrices = csuper.AcceptCash(Convert.ToDouble(txtPrice.Text.Trim()) * Convert.ToDouble(txtNum.Text.Trim()));
        //    _total = _total + totalPrices;
        //    lbxList.Items.Add("单价:" + txtPrice.Text.ToString().PadLeft(5) + " 数量:" + txtNum.Text.ToString().PadLeft(3) + " " + cbxType.SelectedItem.ToString().PadRight(10) + " 总价" + totalPrices.ToString().PadLeft(10) + " 合计:" + _total.ToString().PadLeft(10));
        //    labTotal.Text = _total.ToString();
        //}
        #endregion

        #region 版本2--策略模式
        //private void btnSubmit_Click(object sender, EventArgs e)
        //{
        //    CashContext cc = null;
        //    switch (cbxType.SelectedItem.ToString())
        //    {
        //        case "正常收费":
        //            cc = new CashContext(new CashNormal());
        //            break;
        //        case "满300返100":
        //            cc = new CashContext(new CashReturn("300", "100"));
        //            break;
        //        case "打八折":
        //            cc = new CashContext(new CashRebate("0.8"));
        //            break;
        //    }
        //    var totalPrices = cc.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
        //    _total = _total + totalPrices;
        //    lbxList.Items.Add("单价:" + txtPrice.Text.ToString().PadLeft(5) + " 数量:" + txtNum.Text.ToString().PadLeft(3) + " " + cbxType.SelectedItem.ToString().PadRight(10) + " 总价" + totalPrices.ToString().PadLeft(10) + " 合计:" + _total.ToString().PadLeft(10));
        //    labTotal.Text = _total.ToString();
        //}
        #endregion

        #region 版本3--策略模式 + 简单工厂模式

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var csuper = new CashContext2(cbxType.SelectedItem.ToString());
            var totalPrices = csuper.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            _total = _total + totalPrices;
            lbxList.Items.Add("单价:" + txtPrice.Text.PadLeft(5) + " 数量:" + txtNum.Text.PadLeft(3) + " " + cbxType.SelectedItem.ToString().PadRight(10) + " 总价" + totalPrices.ToString().PadLeft(10) + " 合计:" + _total.ToString().PadLeft(10));
            labTotal.Text = _total.ToString();
        }

        #endregion
    }
}
