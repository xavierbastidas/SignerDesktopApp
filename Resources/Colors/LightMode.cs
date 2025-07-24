namespace SignaBSG.Resources.Colors
{
    public static class LightMode
    {
        // 🎨 Bootstrap 5 Light style colors
        public static Color FormBackground = ColorTranslator.FromHtml("#FFFFFF");
        public static Color PrimaryText = ColorTranslator.FromHtml("#212529");
        public static Color ButtonBackground = ColorTranslator.FromHtml("#0D6EFD");
        public static Color ButtonText = ColorTranslator.FromHtml("#FFFFFF");
        public static Color ButtonHover = ColorTranslator.FromHtml("#0B5ED7");
        public static Color FieldBackground = ColorTranslator.FromHtml("#F8F9FA");
        public static Color Border = ColorTranslator.FromHtml("#CED4DA");
        public static Color MenuBackground = ColorTranslator.FromHtml("#E9ECEF");
        public static Color MenuText = ColorTranslator.FromHtml("#212529");

        public static void ApplyStyle(Form form)
        {
            form.BackColor = FormBackground;
            form.ForeColor = PrimaryText;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            foreach (Control control in form.Controls)
            {
                ApplyStyleToControl(control);
            }

            if (form.MainMenuStrip != null)
            {
                ApplyStyleToMenuStrip(form.MainMenuStrip);
            }
        }

        private static void ApplyStyleToControl(Control control)
        {
            control.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            switch (control)
            {
                case Button button:
                    button.BackColor = ButtonBackground;
                    button.ForeColor = ButtonText;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = Border;
                    button.FlatAppearance.BorderSize = 1;
                    button.MouseEnter += (s, e) => button.BackColor = ButtonHover;
                    button.MouseLeave += (s, e) => button.BackColor = ButtonBackground;
                    break;

                case Label label:
                    label.ForeColor = PrimaryText;
                    label.BorderStyle = BorderStyle.None;
                    break;

                case TextBox textBox:
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = PrimaryText;
                    textBox.BorderStyle = BorderStyle.Fixed3D;
                    break;

                case GroupBox groupBox:
                    groupBox.ForeColor = PrimaryText;
                    groupBox.BackColor = FieldBackground;

                    groupBox.Paint += (s, e) =>
                    {
                        e.Graphics.Clear(FieldBackground);
                        using (var drawFont = new Font("Segoe UI", 9F, FontStyle.Bold))
                        using (var drawBrush = new SolidBrush(PrimaryText))
                        {
                            e.Graphics.DrawString(groupBox.Text, drawFont, drawBrush, 10, 0);
                        }
                    };
                    break;

                case TabControl tabs:
                    tabs.DrawMode = TabDrawMode.OwnerDrawFixed;
                    tabs.Appearance = TabAppearance.Normal;
                    tabs.ItemSize = new Size(100, 25);
                    tabs.SizeMode = TabSizeMode.Normal;
                    tabs.BackColor = FormBackground;
                    tabs.ForeColor = PrimaryText;

                    tabs.DrawItem += (s, e) =>
                    {
                        TabControl tabControl = s as TabControl;
                        bool isSelected = (e.Index == tabControl.SelectedIndex);
                        Brush backgroundBrush = new SolidBrush(isSelected ? FieldBackground : ColorTranslator.FromHtml("#DEE2E6"));
                        Brush textBrush = new SolidBrush(PrimaryText);
                        Rectangle tabBounds = e.Bounds;

                        e.Graphics.FillRectangle(backgroundBrush, tabBounds);
                        e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, e.Font, textBrush, tabBounds.X + 6, tabBounds.Y + 5);
                    };

                    // This event is key to remove the white background
                    tabs.Paint += (s, e) =>
                    {
                        e.Graphics.Clear(FormBackground);
                    };

                    break;

                case TabPage tabPage:
                    tabPage.BackColor = FormBackground;
                    tabPage.ForeColor = PrimaryText;
                    break;

                case MenuStrip menu:
                    ApplyStyleToMenuStrip(menu);
                    break;

                case ContextMenuStrip contextMenu:
                    ApplyStyleToContextMenu(contextMenu);
                    break;
            }

            foreach (Control child in control.Controls)
            {
                ApplyStyleToControl(child);
            }
        }

        private static void ApplyStyleToMenuStrip(MenuStrip menu)
        {
            menu.Renderer = new ToolStripProfessionalRenderer(new LightMenuStyle());
            menu.BackColor = MenuBackground;
            menu.ForeColor = MenuText;

            foreach (ToolStripItem item in menu.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    ApplyStyleToMenuItem(menuItem);
                }
            }
        }

        private static void ApplyStyleToContextMenu(ContextMenuStrip contextMenu)
        {
            contextMenu.Renderer = new ToolStripProfessionalRenderer(new LightMenuStyle());
            contextMenu.BackColor = MenuBackground;
            contextMenu.ForeColor = MenuText;

            foreach (ToolStripItem item in contextMenu.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    ApplyStyleToMenuItem(menuItem);
                }
            }
        }

        private static void ApplyStyleToMenuItem(ToolStripMenuItem item)
        {
            item.BackColor = MenuBackground;
            item.ForeColor = MenuText;

            if (item.DropDown is ToolStripDropDownMenu dropDown)
            {
                dropDown.BackColor = MenuBackground;
                dropDown.ForeColor = MenuText;
                dropDown.Renderer = new ToolStripProfessionalRenderer(new LightMenuStyle());
            }

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenuItem)
                {
                    subMenuItem.BackColor = MenuBackground;
                    subMenuItem.ForeColor = MenuText;

                    if (subMenuItem.DropDown is ToolStripDropDownMenu subDropDown)
                    {
                        subDropDown.BackColor = MenuBackground;
                        subDropDown.ForeColor = MenuText;
                        subDropDown.Renderer = new ToolStripProfessionalRenderer(new LightMenuStyle());
                    }

                    ApplyStyleToMenuItem(subMenuItem); // Recursive call
                }
            }
        }

        private class LightMenuStyle : ProfessionalColorTable
        {
            public override Color MenuItemSelected => ColorTranslator.FromHtml("#DEE2E6");
            public override Color MenuItemBorder => Color.Transparent;
            public override Color ToolStripDropDownBackground => MenuBackground;
            public override Color MenuItemSelectedGradientBegin => ColorTranslator.FromHtml("#DEE2E6");
            public override Color MenuItemSelectedGradientEnd => ColorTranslator.FromHtml("#DEE2E6");
            public override Color MenuItemPressedGradientBegin => MenuBackground;
            public override Color MenuItemPressedGradientEnd => MenuBackground;

            public override Color ImageMarginGradientBegin => MenuBackground;
            public override Color ImageMarginGradientMiddle => MenuBackground;
            public override Color ImageMarginGradientEnd => MenuBackground;
            public override Color ImageMarginRevealedGradientBegin => MenuBackground;
            public override Color ImageMarginRevealedGradientMiddle => MenuBackground;
            public override Color ImageMarginRevealedGradientEnd => MenuBackground;
        }
    }
}
