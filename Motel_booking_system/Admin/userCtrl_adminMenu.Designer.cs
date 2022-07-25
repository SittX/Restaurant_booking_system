namespace Restaurant_booking_system.Admin
{
    partial class userCtrl_adminMenu
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
            this.restaurantDataSet1 = new Restaurant_booking_system.RestaurantDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantDataSet1
            // 
            this.restaurantDataSet1.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet1.Namespace = "http://tempuri.org/RestaurantDataSet.xsd";
            this.restaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userCtrl_adminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Name = "userCtrl_adminMenu";
            this.Size = new System.Drawing.Size(887, 695);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestaurantDataSet restaurantDataSet1;
    }
}
