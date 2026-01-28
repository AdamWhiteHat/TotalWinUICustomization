using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TotalWinUICustomization.Controls;
using static System.Windows.Forms.CheckedListBox;

namespace TotalWinUICustomization
{
    public partial class PendingChangesForm : Form
    {
        public ReadOnlyCollection<SettingUpdateAction> CheckedItems
        {
            get
            {
                return new ReadOnlyCollection<SettingUpdateAction>(
                    checkedListPendingChanges.CheckedItems.Cast<SettingUpdateAction>().ToList()
                    );
            }
        }

        protected List<SettingUpdateAction> _items { get; set; }

        public PendingChangesForm(Form owner, List<SettingUpdateAction> items)
        {
            InitializeComponent();
            this.Owner = owner;
            _items = items;

            this.Load += PendingChangesForm_Load;
        }

        private void PendingChangesForm_Load(object sender, EventArgs e)
        {
            this.checkedListPendingChanges.DisplayMember = "Display";
            this.checkedListPendingChanges.ValueMember = "Save";

            foreach (var item in _items)
            {
                checkedListPendingChanges.Items.Add(item, item.Save);
            }

            //this.checkedListPendingChanges.DataSource = new BindingList<SettingUpdateAction>(_items);
            //
            //for (int i = 0; i < checkedListPendingChanges.Items.Count; ++i)
            //{
            //    checkedListPendingChanges.SetItemChecked(i, _items[i].Save);
            //}
        }
    }
}
