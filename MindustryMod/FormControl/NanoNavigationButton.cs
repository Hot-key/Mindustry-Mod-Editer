using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindustryMod.FormControl
{
    [DefaultEvent("Click")]
    public partial class NanoNavigationButton : UserControl
    {
        private bool isSelected = false;

        private Color activeColor;
        private Color defaultColor;

        [
            Category("모양"),
            Description("버튼에 표시되는 문자열을 지정합니다."),
        ]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        [
            Category("모양"),
            Description("버튼에 표시되는 아이콘를 지정합니다."),
        ]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Icon
        {
            get => pictureBox2.Image;
            set => pictureBox2.Image = value;
        }

        [
            Category("동작"),
            Description("버튼의 활성화 여부를 설정합니다."),
        ]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool IsSelected
        {
            get => isSelected;
            set => isSelected = value;
        }


        [
            Category("모양"),
            Description("버튼의 활성화 색상을 지정합니다."),
        ]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ActiveColor
        {
            get => activeColor;
            set => activeColor = value;
        }


        [
            Category("모양"),
            Description("버튼의 기본 색상을 지정합니다."),
        ]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color DefaultColor
        {
            get => defaultColor;
            set => defaultColor = value;
        }


        public NanoNavigationButton()
        {
            InitializeComponent();
        }

        private void NanoNavigationButton_Load(object sender, EventArgs e)
        {
            this.BackColor = isSelected ? activeColor : defaultColor;
        }

        private void NanoNavigationButton_Click(object sender, EventArgs e)
        {
            foreach (Control parentControl in Parent.Controls)
            {
                if (parentControl is NanoNavigationButton parentButton)
                {
                    parentButton.isSelected = false;
                    parentButton.BackColor = parentButton.isSelected ? parentButton.activeColor : parentButton.defaultColor;
                }
            }

            this.isSelected = true;
            this.BackColor = isSelected ? activeColor : defaultColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
