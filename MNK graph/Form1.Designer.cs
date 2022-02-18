namespace MNK_graph
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox FilesInBox;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yList = new System.Windows.Forms.TextBox();
            this.xList = new System.Windows.Forms.TextBox();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraphBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TestTextOut = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.import = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            FilesInBox = new System.Windows.Forms.GroupBox();
            FilesInBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.GraphBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // FilesInBox
            // 
            FilesInBox.Controls.Add(this.label2);
            FilesInBox.Controls.Add(this.label1);
            FilesInBox.Controls.Add(this.yList);
            FilesInBox.Controls.Add(this.xList);
            FilesInBox.Location = new System.Drawing.Point(474, 12);
            FilesInBox.Name = "FilesInBox";
            FilesInBox.Size = new System.Drawing.Size(296, 99);
            FilesInBox.TabIndex = 4;
            FilesInBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yList
            // 
            this.yList.Location = new System.Drawing.Point(23, 58);
            this.yList.Name = "yList";
            this.yList.Size = new System.Drawing.Size(222, 20);
            this.yList.TabIndex = 1;
            // 
            // xList
            // 
            this.xList.Location = new System.Drawing.Point(23, 20);
            this.xList.Name = "xList";
            this.xList.Size = new System.Drawing.Size(222, 20);
            this.xList.TabIndex = 0;
            this.xList.TextChanged += new System.EventHandler(this.xList_TextChanged);
            // 
            // graph
            // 
            this.graph.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            chartArea2.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Позначення:";
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(6, 10);
            this.graph.Name = "graph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "Точки";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "ax+b";
            this.graph.Series.Add(series3);
            this.graph.Series.Add(series4);
            this.graph.Size = new System.Drawing.Size(429, 410);
            this.graph.TabIndex = 1;
            this.graph.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "Графік МНК";
            this.graph.Titles.Add(title2);
            this.graph.Click += new System.EventHandler(this.graph_1_Click);
            // 
            // GraphBox
            // 
            this.GraphBox.Controls.Add(this.graph);
            this.GraphBox.Location = new System.Drawing.Point(21, 12);
            this.GraphBox.Name = "GraphBox";
            this.GraphBox.Size = new System.Drawing.Size(441, 426);
            this.GraphBox.TabIndex = 2;
            this.GraphBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Побудувати графік";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // TestTextOut
            // 
            this.TestTextOut.Location = new System.Drawing.Point(474, 395);
            this.TestTextOut.Name = "TestTextOut";
            this.TestTextOut.Size = new System.Drawing.Size(290, 20);
            this.TestTextOut.TabIndex = 6;
            this.TestTextOut.TextChanged += new System.EventHandler(this.TestTextOut_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(468, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(215, 13);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 44);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "Очистити";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // import
            // 
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.import.Location = new System.Drawing.Point(474, 117);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 24);
            this.import.TabIndex = 1;
            this.import.Text = "Імпорт txt";
            this.import.UseMnemonic = false;
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(471, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Коефіцієнти:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.import);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TestTextOut);
            this.Controls.Add(FilesInBox);
            this.Controls.Add(this.GraphBox);
            this.Name = "Form1";
            this.Text = "Form1";
            FilesInBox.ResumeLayout(false);
            FilesInBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.GraphBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.GroupBox GraphBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yList;
        private System.Windows.Forms.TextBox xList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TestTextOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Label label3;
    }
}

