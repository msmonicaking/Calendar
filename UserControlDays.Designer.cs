
namespace Calendar
{
   partial class UserControlDays
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.daylabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // daylabel
         // 
         this.daylabel.AutoSize = true;
         this.daylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.daylabel.Location = new System.Drawing.Point(113, 0);
         this.daylabel.Name = "daylabel";
         this.daylabel.Size = new System.Drawing.Size(34, 25);
         this.daylabel.TabIndex = 0;
         this.daylabel.Text = "00";
         // 
         // UserControlDays
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.Controls.Add(this.daylabel);
         this.Name = "UserControlDays";
         this.Load += new System.EventHandler(this.UserControlDays_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label daylabel;
   }
}
