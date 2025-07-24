public static class DarkMode
{
    // 🎨 Bootstrap 5 Dark style colors
    public static Color FormBackground = ColorTranslator.FromHtml("#212529");
    public static Color PrimaryText = ColorTranslator.FromHtml("#FFFFFF");
    public static Color ButtonBackground = ColorTranslator.FromHtml("#0D6EFD");
    public static Color ButtonText = ColorTranslator.FromHtml("#FFFFFF");
    public static Color ButtonHover = ColorTranslator.FromHtml("#0B5ED7");
    public static Color FieldBackground = ColorTranslator.FromHtml("#343A40");
    public static Color Border = ColorTranslator.FromHtml("#495057");
    public static Color MenuBackground = ColorTranslator.FromHtml("#343A40");
    public static Color MenuText = ColorTranslator.FromHtml("#FFFFFF");

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
                textBox.BackColor = Color.FromArgb(64, 64, 64);
                textBox.ForeColor = PrimaryText;
                textBox.BorderStyle = BorderStyle.Fixed3D;
                textBox.Font = new Font("Segoe UI", 10F);
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
                tabs.ItemSize = new Size(120, 30);
                tabs.SizeMode = TabSizeMode.Fixed;
                tabs.Multiline = false;

                // tabs.SetStyle(ControlStyles.UserPaint, true); // important

                tabs.DrawItem += (s, e) =>
                {
                    TabControl tab = s as TabControl;
                    bool isSelected = (e.Index == tab.SelectedIndex);
                    Rectangle tabBounds = e.Bounds;

                    // Background for selected and unselected tabs
                    Color backgroundColor = isSelected ? FieldBackground : ColorTranslator.FromHtml("#2B3035");

                    using (SolidBrush backBrush = new SolidBrush(backgroundColor))
                    using (SolidBrush textBrush = new SolidBrush(PrimaryText))
                    {
                        // Tab background
                        e.Graphics.FillRectangle(backBrush, tabBounds);

                        // Centered text
                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };

                        e.Graphics.DrawString(tab.TabPages[e.Index].Text, e.Font, textBrush, tabBounds, sf);
                    }
                };

                // Paints the area that normally remains white behind the tabs
                tabs.Paint += (s, e) =>
                {
                    Rectangle tabRect = tabs.GetTabRect(0); // Height of the tab area
                    Rectangle headerRect = new Rectangle(0, 0, tabs.Width, tabRect.Bottom + 1);

                    using (SolidBrush headerBrush = new SolidBrush(FormBackground))
                    {
                        e.Graphics.FillRectangle(headerBrush, headerRect);
                    }
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
        menu.Renderer = new ToolStripProfessionalRenderer(new MenuStyle());
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
        contextMenu.Renderer = new ToolStripProfessionalRenderer(new MenuStyle());
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
            dropDown.Renderer = new ToolStripProfessionalRenderer(new MenuStyle());
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
                    subDropDown.Renderer = new ToolStripProfessionalRenderer(new MenuStyle());
                }

                ApplyStyleToMenuItem(subMenuItem); // Recursive call
            }
        }
    }

    private class MenuStyle : ProfessionalColorTable
    {
        public override Color MenuItemSelected => ColorTranslator.FromHtml("#495057");
        public override Color MenuItemBorder => Color.Transparent;
        public override Color ToolStripDropDownBackground => MenuBackground;
        public override Color MenuItemSelectedGradientBegin => ColorTranslator.FromHtml("#495057");
        public override Color MenuItemSelectedGradientEnd => ColorTranslator.FromHtml("#495057");
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
