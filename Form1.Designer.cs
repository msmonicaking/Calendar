﻿
namespace Calendar
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
         this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
         this.buttonnext = new System.Windows.Forms.Button();
         this.buttonprevious = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.LBDATE = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // daycontainer
         // 
         this.daycontainer.Location = new System.Drawing.Point(10, 125);
         this.daycontainer.Name = "daycontainer";
         this.daycontainer.Size = new System.Drawing.Size(1100, 625);
         this.daycontainer.TabIndex = 0;
         // 
         // buttonnext
         // 
         this.buttonnext.Location = new System.Drawing.Point(1033, 782);
         this.buttonnext.Name = "buttonnext";
         this.buttonnext.Size = new System.Drawing.Size(75, 23);
         this.buttonnext.TabIndex = 1;
         this.buttonnext.Text = "Next";
         this.buttonnext.UseVisualStyleBackColor = true;
         this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
         // 
         // buttonprevious
         // 
         this.buttonprevious.Location = new System.Drawing.Point(952, 782);
         this.buttonprevious.Name = "buttonprevious";
         this.buttonprevious.Size = new System.Drawing.Size(75, 23);
         this.buttonprevious.TabIndex = 2;
         this.buttonprevious.Text = "Previous";
         this.buttonprevious.UseVisualStyleBackColor = true;
         this.buttonprevious.Click += new System.EventHandler(this.buttonprevious_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(50, 82);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(69, 20);
         this.label1.TabIndex = 3;
         this.label1.Text = "Sunday";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(205, 82);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(69, 20);
         this.label2.TabIndex = 4;
         this.label2.Text = "Monday";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(360, 82);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(79, 20);
         this.label3.TabIndex = 6;
         this.label3.Text = "Tuesday";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(670, 82);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(89, 20);
         this.label5.TabIndex = 8;
         this.label5.Text = "Thursday";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(515, 82);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(99, 20);
         this.label6.TabIndex = 7;
         this.label6.Text = "Wednesday";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(825, 82);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(69, 20);
         this.label7.TabIndex = 9;
         this.label7.Text = "Friday";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(980, 82);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(89, 20);
         this.label8.TabIndex = 10;
         this.label8.Text = "Saturday";
         // 
         // LBDATE
         // 
         this.LBDATE.AutoSize = true;
         this.LBDATE.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LBDATE.Location = new System.Drawing.Point(484, 20);
         this.LBDATE.Name = "LBDATE";
         this.LBDATE.Size = new System.Drawing.Size(152, 28);
         this.LBDATE.TabIndex = 11;
         this.LBDATE.Text = "MONTH YEAR";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1120, 826);
         this.Controls.Add(this.LBDATE);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.buttonprevious);
         this.Controls.Add(this.buttonnext);
         this.Controls.Add(this.daycontainer);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load_1);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.FlowLayoutPanel daycontainer;
      private System.Windows.Forms.Button buttonnext;
      private System.Windows.Forms.Button buttonprevious;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label LBDATE;
   }
}

