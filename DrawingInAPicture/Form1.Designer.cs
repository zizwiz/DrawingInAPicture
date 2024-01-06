
namespace DrawingInAPicture
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picbx_canvas = new System.Windows.Forms.PictureBox();
            this.btn_draw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_ty = new System.Windows.Forms.TextBox();
            this.txtbx_tx = new System.Windows.Forms.TextBox();
            this.txtbx_by = new System.Windows.Forms.TextBox();
            this.txtbx_bx = new System.Windows.Forms.TextBox();
            this.cbobx_colours = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picbx_canvas
            // 
            this.picbx_canvas.BackColor = System.Drawing.Color.White;
            this.picbx_canvas.Image = ((System.Drawing.Image)(resources.GetObject("picbx_canvas.Image")));
            this.picbx_canvas.Location = new System.Drawing.Point(12, 12);
            this.picbx_canvas.Name = "picbx_canvas";
            this.picbx_canvas.Size = new System.Drawing.Size(778, 411);
            this.picbx_canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbx_canvas.TabIndex = 0;
            this.picbx_canvas.TabStop = false;
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(406, 491);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(109, 43);
            this.btn_draw.TabIndex = 1;
            this.btn_draw.Text = "Draw";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "BY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 501);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "BX";
            // 
            // txtbx_ty
            // 
            this.txtbx_ty.Location = new System.Drawing.Point(79, 440);
            this.txtbx_ty.Name = "txtbx_ty";
            this.txtbx_ty.Size = new System.Drawing.Size(100, 26);
            this.txtbx_ty.TabIndex = 6;
            this.txtbx_ty.Text = "10";
            // 
            // txtbx_tx
            // 
            this.txtbx_tx.Location = new System.Drawing.Point(255, 440);
            this.txtbx_tx.Name = "txtbx_tx";
            this.txtbx_tx.Size = new System.Drawing.Size(100, 26);
            this.txtbx_tx.TabIndex = 7;
            this.txtbx_tx.Text = "100";
            // 
            // txtbx_by
            // 
            this.txtbx_by.Location = new System.Drawing.Point(81, 498);
            this.txtbx_by.Name = "txtbx_by";
            this.txtbx_by.Size = new System.Drawing.Size(100, 26);
            this.txtbx_by.TabIndex = 8;
            this.txtbx_by.Text = "100";
            // 
            // txtbx_bx
            // 
            this.txtbx_bx.Location = new System.Drawing.Point(255, 498);
            this.txtbx_bx.Name = "txtbx_bx";
            this.txtbx_bx.Size = new System.Drawing.Size(100, 26);
            this.txtbx_bx.TabIndex = 9;
            this.txtbx_bx.Text = "100";
            // 
            // cbobx_colours
            // 
            this.cbobx_colours.FormattingEnabled = true;
            this.cbobx_colours.Location = new System.Drawing.Point(521, 438);
            this.cbobx_colours.Name = "cbobx_colours";
            this.cbobx_colours.Size = new System.Drawing.Size(250, 28);
            this.cbobx_colours.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Choose a colour";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(532, 491);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 43);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(662, 491);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(109, 43);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 546);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbobx_colours);
            this.Controls.Add(this.txtbx_bx);
            this.Controls.Add(this.txtbx_by);
            this.Controls.Add(this.txtbx_tx);
            this.Controls.Add(this.txtbx_ty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.picbx_canvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Drawing in a picture";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbx_canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx_canvas;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_ty;
        private System.Windows.Forms.TextBox txtbx_tx;
        private System.Windows.Forms.TextBox txtbx_by;
        private System.Windows.Forms.TextBox txtbx_bx;
        private System.Windows.Forms.ComboBox cbobx_colours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_close;
    }
}

