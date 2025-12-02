namespace RayTracing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSphereRefl = new System.Windows.Forms.Label();
            this.lblCubeRefl = new System.Windows.Forms.Label();
            this.sphereReflectionSlider = new System.Windows.Forms.TrackBar();
            this.cubeReflectionSlider = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSphereRefr = new System.Windows.Forms.Label();
            this.lblCubeRefr = new System.Windows.Forms.Label();
            this.sphereRefractionSlider = new System.Windows.Forms.TrackBar();
            this.cubeRefractionSlider = new System.Windows.Forms.TrackBar();
            this.twoLightsCB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.downWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.upWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.leftWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.rightWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.backWallSpecularCB = new System.Windows.Forms.CheckBox();
            this.frontWallSpecularCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphereReflectionSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubeReflectionSlider)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphereRefractionSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubeRefractionSlider)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 564);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(665, 535);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ray Trace (Рендеринг)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSphereRefl);
            this.groupBox1.Controls.Add(this.lblCubeRefl);
            this.groupBox1.Controls.Add(this.sphereReflectionSlider);
            this.groupBox1.Controls.Add(this.cubeReflectionSlider);
            this.groupBox1.Location = new System.Drawing.Point(665, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коэф. Отражения (Refl)";
            // 
            // lblSphereRefl
            // 
            this.lblSphereRefl.AutoSize = true;
            this.lblSphereRefl.Location = new System.Drawing.Point(6, 73);
            this.lblSphereRefl.Name = "lblSphereRefl";
            this.lblSphereRefl.Size = new System.Drawing.Size(59, 13);
            this.lblSphereRefl.TabIndex = 3;
            this.lblSphereRefl.Text = "Шар (0.00)";
            // 
            // lblCubeRefl
            // 
            this.lblCubeRefl.AutoSize = true;
            this.lblCubeRefl.Location = new System.Drawing.Point(6, 21);
            this.lblCubeRefl.Name = "lblCubeRefl";
            this.lblCubeRefl.Size = new System.Drawing.Size(56, 13);
            this.lblCubeRefl.TabIndex = 3;
            this.lblCubeRefl.Text = "Куб (0.00)";
            // 
            // sphereReflectionSlider
            // 
            this.sphereReflectionSlider.Location = new System.Drawing.Point(6, 89);
            this.sphereReflectionSlider.Maximum = 100;
            this.sphereReflectionSlider.Name = "sphereReflectionSlider";
            this.sphereReflectionSlider.Size = new System.Drawing.Size(138, 45);
            this.sphereReflectionSlider.TabIndex = 2;
            this.sphereReflectionSlider.TickFrequency = 10;
            this.sphereReflectionSlider.Scroll += new System.EventHandler(this.reflectionSlider_Scroll);
            // 
            // cubeReflectionSlider
            // 
            this.cubeReflectionSlider.Location = new System.Drawing.Point(6, 37);
            this.cubeReflectionSlider.Maximum = 100;
            this.cubeReflectionSlider.Name = "cubeReflectionSlider";
            this.cubeReflectionSlider.Size = new System.Drawing.Size(138, 45);
            this.cubeReflectionSlider.TabIndex = 2;
            this.cubeReflectionSlider.TickFrequency = 10;
            this.cubeReflectionSlider.Scroll += new System.EventHandler(this.reflectionSlider_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSphereRefr);
            this.groupBox2.Controls.Add(this.lblCubeRefr);
            this.groupBox2.Controls.Add(this.sphereRefractionSlider);
            this.groupBox2.Controls.Add(this.cubeRefractionSlider);
            this.groupBox2.Location = new System.Drawing.Point(665, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 130);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Коэф. Прозрачности (Refr)";
            // 
            // lblSphereRefr
            // 
            this.lblSphereRefr.AutoSize = true;
            this.lblSphereRefr.Location = new System.Drawing.Point(6, 73);
            this.lblSphereRefr.Name = "lblSphereRefr";
            this.lblSphereRefr.Size = new System.Drawing.Size(59, 13);
            this.lblSphereRefr.TabIndex = 3;
            this.lblSphereRefr.Text = "Шар (0.00)";
            // 
            // lblCubeRefr
            // 
            this.lblCubeRefr.AutoSize = true;
            this.lblCubeRefr.Location = new System.Drawing.Point(6, 21);
            this.lblCubeRefr.Name = "lblCubeRefr";
            this.lblCubeRefr.Size = new System.Drawing.Size(56, 13);
            this.lblCubeRefr.TabIndex = 3;
            this.lblCubeRefr.Text = "Куб (0.00)";
            // 
            // sphereRefractionSlider
            // 
            this.sphereRefractionSlider.Location = new System.Drawing.Point(6, 89);
            this.sphereRefractionSlider.Maximum = 100;
            this.sphereRefractionSlider.Name = "sphereRefractionSlider";
            this.sphereRefractionSlider.Size = new System.Drawing.Size(138, 45);
            this.sphereRefractionSlider.TabIndex = 2;
            this.sphereRefractionSlider.TickFrequency = 10;
            this.sphereRefractionSlider.Scroll += new System.EventHandler(this.refractionSlider_Scroll);
            // 
            // cubeRefractionSlider
            // 
            this.cubeRefractionSlider.Location = new System.Drawing.Point(6, 37);
            this.cubeRefractionSlider.Maximum = 100;
            this.cubeRefractionSlider.Name = "cubeRefractionSlider";
            this.cubeRefractionSlider.Size = new System.Drawing.Size(138, 45);
            this.cubeRefractionSlider.TabIndex = 2;
            this.cubeRefractionSlider.TickFrequency = 10;
            this.cubeRefractionSlider.Scroll += new System.EventHandler(this.refractionSlider_Scroll);
            // 
            // twoLightsCB
            // 
            this.twoLightsCB.AutoSize = true;
            this.twoLightsCB.Location = new System.Drawing.Point(671, 497);
            this.twoLightsCB.Name = "twoLightsCB";
            this.twoLightsCB.Size = new System.Drawing.Size(117, 17);
            this.twoLightsCB.TabIndex = 4;
            this.twoLightsCB.Text = "Второй источник";
            this.twoLightsCB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.downWallSpecularCB);
            this.groupBox3.Controls.Add(this.upWallSpecularCB);
            this.groupBox3.Controls.Add(this.leftWallSpecularCB);
            this.groupBox3.Controls.Add(this.rightWallSpecularCB);
            this.groupBox3.Controls.Add(this.backWallSpecularCB);
            this.groupBox3.Controls.Add(this.frontWallSpecularCB);
            this.groupBox3.Location = new System.Drawing.Point(665, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 158);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Зеркальность стен";
            // 
            // downWallSpecularCB
            // 
            this.downWallSpecularCB.AutoSize = true;
            this.downWallSpecularCB.Location = new System.Drawing.Point(6, 135);
            this.downWallSpecularCB.Name = "downWallSpecularCB";
            this.downWallSpecularCB.Size = new System.Drawing.Size(107, 17);
            this.downWallSpecularCB.TabIndex = 5;
            this.downWallSpecularCB.Text = "Нижняя стена";
            this.downWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // upWallSpecularCB
            // 
            this.upWallSpecularCB.AutoSize = true;
            this.upWallSpecularCB.Location = new System.Drawing.Point(6, 112);
            this.upWallSpecularCB.Name = "upWallSpecularCB";
            this.upWallSpecularCB.Size = new System.Drawing.Size(110, 17);
            this.upWallSpecularCB.TabIndex = 4;
            this.upWallSpecularCB.Text = "Верхняя стена";
            this.upWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // leftWallSpecularCB
            // 
            this.leftWallSpecularCB.AutoSize = true;
            this.leftWallSpecularCB.Location = new System.Drawing.Point(6, 89);
            this.leftWallSpecularCB.Name = "leftWallSpecularCB";
            this.leftWallSpecularCB.Size = new System.Drawing.Size(95, 17);
            this.leftWallSpecularCB.TabIndex = 3;
            this.leftWallSpecularCB.Text = "Левая стена";
            this.leftWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // rightWallSpecularCB
            // 
            this.rightWallSpecularCB.AutoSize = true;
            this.rightWallSpecularCB.Location = new System.Drawing.Point(6, 66);
            this.rightWallSpecularCB.Name = "rightWallSpecularCB";
            this.rightWallSpecularCB.Size = new System.Drawing.Size(101, 17);
            this.rightWallSpecularCB.TabIndex = 2;
            this.rightWallSpecularCB.Text = "Правая стена";
            this.rightWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // backWallSpecularCB
            // 
            this.backWallSpecularCB.AutoSize = true;
            this.backWallSpecularCB.Location = new System.Drawing.Point(6, 43);
            this.backWallSpecularCB.Name = "backWallSpecularCB";
            this.backWallSpecularCB.Size = new System.Drawing.Size(97, 17);
            this.backWallSpecularCB.TabIndex = 1;
            this.backWallSpecularCB.Text = "Задняя стена";
            this.backWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // frontWallSpecularCB
            // 
            this.frontWallSpecularCB.AutoSize = true;
            this.frontWallSpecularCB.Location = new System.Drawing.Point(6, 20);
            this.frontWallSpecularCB.Name = "frontWallSpecularCB";
            this.frontWallSpecularCB.Size = new System.Drawing.Size(103, 17);
            this.frontWallSpecularCB.TabIndex = 0;
            this.frontWallSpecularCB.Text = "Передняя стена";
            this.frontWallSpecularCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 585);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.twoLightsCB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ray Tracing | Custom Edition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphereReflectionSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubeReflectionSlider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphereRefractionSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cubeRefractionSlider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox twoLightsCB;
        // --- Элементы для объектов (остались TrackBar) ---
        private System.Windows.Forms.TrackBar cubeReflectionSlider;
        private System.Windows.Forms.TrackBar sphereReflectionSlider;
        private System.Windows.Forms.TrackBar cubeRefractionSlider;
        private System.Windows.Forms.TrackBar sphereRefractionSlider;
        private System.Windows.Forms.Label lblSphereRefl;
        private System.Windows.Forms.Label lblCubeRefl;
        private System.Windows.Forms.Label lblSphereRefr;
        private System.Windows.Forms.Label lblCubeRefr;

        // --- Элементы для Стен (GroupBox и CheckBox) ---
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox downWallSpecularCB;
        private System.Windows.Forms.CheckBox upWallSpecularCB;
        private System.Windows.Forms.CheckBox leftWallSpecularCB;
        private System.Windows.Forms.CheckBox rightWallSpecularCB;
        private System.Windows.Forms.CheckBox backWallSpecularCB;
        private System.Windows.Forms.CheckBox frontWallSpecularCB;
    }
}