using System.Windows.Forms;

namespace EditableDataGridViewComboBox
{
    public class DataGridViewComboEditBoxColumn : DataGridViewComboBoxColumn
    {
        public DataGridViewComboEditBoxColumn()
        {
            DataGridViewComboEditBoxCell obj = new DataGridViewComboEditBoxCell();
            this.CellTemplate = obj;
        }
    }
}