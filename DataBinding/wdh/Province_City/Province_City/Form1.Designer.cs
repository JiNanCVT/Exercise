namespace Province_City
{
    partial class Province_City
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Province = new System.Windows.Forms.ComboBox();
            this.City = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._province = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Province
            // 
            this.Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Province.FormattingEnabled = true;
            this.Province.Items.AddRange(new object[] 
                                            {
                                            "北京市","广东省","天津市","安徽省","上海市",
                                            "福建省","重庆市","江西省","香港特别行政区",
                                            "山东省","澳门特别行政区","河南省","内蒙古自治区",
                                            "湖北省","新疆维吾尔自治区","湖南省", "宁夏回族自治区",
                                            "浙江省", "西藏自治区","海南省","广西壮族自治区",
                                            "四川省","河北省","贵州省","山西省","云南省",
                                            "辽宁省","陕西省","吉林省","甘肃省", "黑龙江省",
                                            "青海省","江苏省","台湾省"
                                            }
                                         );
            this.Province.Location = new System.Drawing.Point(137, 2);
            this.Province.Name = "Province";
            this.Province.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Province.Size = new System.Drawing.Size(91, 20);
            this.Province.TabIndex = 0;
            this.Province.SelectedIndexChanged += new System.EventHandler(this.Province_SelectedIndexChanged);
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.Color.AliceBlue;
            //this.City.Enabled = false;
            this.City.FormattingEnabled = true;
            this.City.ItemHeight = 12;
            this.City.Location = new System.Drawing.Point(137, 54);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(91, 196);
            this.City.TabIndex = 1;
            this.City.SelectedIndexChanged += new System.EventHandler(this.City_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 281);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(77, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "确定";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "省份";
            // 
            // _province
            // 
            this._province.AutoSize = true;
            this._province.Location = new System.Drawing.Point(102, 54);
            this._province.Name = "_province";
            this._province.Size = new System.Drawing.Size(29, 12);
            this._province.TabIndex = 7;
            this._province.Text = "城市";
            this._province.Click += new System.EventHandler(this._province_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "省会";
            // 
            // main
            // 
            this.main.FormattingEnabled = true;
            this.main.Location = new System.Drawing.Point(137, 31);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(91, 20);
            this.main.TabIndex = 9;
            this.main.SelectedIndexChanged += new System.EventHandler(this.main_SelectedIndexChanged);
            // 
            // Province_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 339);
            this.Controls.Add(this.main);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._province);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Province);
            this.Name = "Province_City";
            this.Text = "显示窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Province;
        private System.Windows.Forms.ListBox City;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _province;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox main;
    }
}

