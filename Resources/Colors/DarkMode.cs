
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class DarkMode
{
    // 🎨 Colores estilo Bootstrap 5 Dark
    public static Color FondoFormulario = ColorTranslator.FromHtml("#212529");
    public static Color TextoPrincipal = ColorTranslator.FromHtml("#FFFFFF");
    public static Color BotonFondo = ColorTranslator.FromHtml("#0D6EFD");
    public static Color BotonTexto = ColorTranslator.FromHtml("#FFFFFF");
    public static Color BotonHover = ColorTranslator.FromHtml("#0B5ED7");
    public static Color CampoFondo = ColorTranslator.FromHtml("#343A40");
    public static Color Borde = ColorTranslator.FromHtml("#495057");
    public static Color MenuFondo = ColorTranslator.FromHtml("#343A40");
    public static Color MenuTexto = ColorTranslator.FromHtml("#FFFFFF");

    public static void AplicarEstilo(Form formulario)
    {
        formulario.BackColor = FondoFormulario;
        formulario.ForeColor = TextoPrincipal;
        formulario.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

        foreach (Control control in formulario.Controls)
        {
            AplicarEstiloAControl(control);
        }

        if (formulario.MainMenuStrip != null)
        {
            AplicarEstiloAMenuStrip(formulario.MainMenuStrip);
        }
    }

    private static void AplicarEstiloAControl(Control control)
    {
        control.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

        switch (control)
        {
            case Button boton:
                boton.BackColor = BotonFondo;
                boton.ForeColor = BotonTexto;
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderColor = Borde;
                boton.FlatAppearance.BorderSize = 1;
                boton.MouseEnter += (s, e) => boton.BackColor = BotonHover;
                boton.MouseLeave += (s, e) => boton.BackColor = BotonFondo;
                break;

            case Label lbl:
                lbl.ForeColor = TextoPrincipal;
                lbl.BorderStyle = BorderStyle.None;
                break;

            case TextBox txt:
                txt.BackColor = Color.FromArgb(64, 64, 64); // Gris oscuro
                txt.ForeColor = TextoPrincipal;
                txt.BorderStyle = BorderStyle.None;
                txt.Font = new Font("Segoe UI", 10F);
                break;

            case GroupBox group:
                group.ForeColor = TextoPrincipal;
                group.BackColor = CampoFondo;

                group.Paint += (s, e) =>
                {
                    e.Graphics.Clear(CampoFondo);
                    using (var drawFont = new Font("Segoe UI", 9F, FontStyle.Bold))
                    using (var drawBrush = new SolidBrush(TextoPrincipal))
                    {
                        e.Graphics.DrawString(group.Text, drawFont, drawBrush, 10, 0);
                    }
                };
                break;
            case TabControl tabs:
                tabs.DrawMode = TabDrawMode.OwnerDrawFixed;
                tabs.Appearance = TabAppearance.Normal;
                tabs.ItemSize = new Size(120, 30);
                tabs.SizeMode = TabSizeMode.Fixed;
                tabs.Multiline = false;

               // tabs.SetStyle(ControlStyles.UserPaint, true); // importante

                tabs.DrawItem += (s, e) =>
                {
                    TabControl tab = s as TabControl;
                    bool isSelected = (e.Index == tab.SelectedIndex);
                    Rectangle tabBounds = e.Bounds;

                    // Fondo de pestaña seleccionada y no seleccionada
                    Color backgroundColor = isSelected ? CampoFondo : ColorTranslator.FromHtml("#2B3035");

                    using (SolidBrush backBrush = new SolidBrush(backgroundColor))
                    using (SolidBrush textBrush = new SolidBrush(TextoPrincipal))
                    {
                        // Fondo de la pestaña
                        e.Graphics.FillRectangle(backBrush, tabBounds);

                        // Texto centrado
                        StringFormat sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center
                        };

                        e.Graphics.DrawString(tab.TabPages[e.Index].Text, e.Font, textBrush, tabBounds, sf);
                    }
                };

                // Dibuja el área que normalmente queda blanca detrás de las pestañas
                tabs.Paint += (s, e) =>
                {
                    Rectangle tabRect = tabs.GetTabRect(0); // Altura del área de pestañas
                    Rectangle headerRect = new Rectangle(0, 0, tabs.Width, tabRect.Bottom + 1);

                    using (SolidBrush headerBrush = new SolidBrush(FondoFormulario))
                    {
                        e.Graphics.FillRectangle(headerBrush, headerRect);
                    }
                };

                break;




            case TabPage tabPage:
                tabPage.BackColor = FondoFormulario;
                tabPage.ForeColor = TextoPrincipal;
                break;

            case MenuStrip menu:
                AplicarEstiloAMenuStrip(menu);
                break;

            case ContextMenuStrip contextMenu:
                AplicarEstiloAContextMenu(contextMenu);
                break;
        }

        foreach (Control hijo in control.Controls)
        {
            AplicarEstiloAControl(hijo);
        }
    }



    private static void AplicarEstiloAMenuStrip(MenuStrip menu)
    {
        menu.Renderer = new ToolStripProfessionalRenderer(new EstiloMenu());
        menu.BackColor = MenuFondo;
        menu.ForeColor = MenuTexto;

        foreach (ToolStripItem item in menu.Items)
        {
            if (item is ToolStripMenuItem menuItem)
            {
                AplicarEstiloMenuItem(menuItem);
            }
        }
    }

    private static void AplicarEstiloAContextMenu(ContextMenuStrip contextMenu)
    {
        contextMenu.Renderer = new ToolStripProfessionalRenderer(new EstiloMenu());
        contextMenu.BackColor = MenuFondo;
        contextMenu.ForeColor = MenuTexto;

        foreach (ToolStripItem item in contextMenu.Items)
        {
            if (item is ToolStripMenuItem menuItem)
            {
                AplicarEstiloMenuItem(menuItem);
            }
        }
    }

    private static void AplicarEstiloMenuItem(ToolStripMenuItem item)
    {
        item.BackColor = MenuFondo;
        item.ForeColor = MenuTexto;

        if (item.DropDown is ToolStripDropDownMenu dropDown)
        {
            dropDown.BackColor = MenuFondo;
            dropDown.ForeColor = MenuTexto;
            dropDown.Renderer = new ToolStripProfessionalRenderer(new EstiloMenu());
        }

        foreach (ToolStripItem subItem in item.DropDownItems)
        {
            if (subItem is ToolStripMenuItem subMenuItem)
            {
                subMenuItem.BackColor = MenuFondo;
                subMenuItem.ForeColor = MenuTexto;

                if (subMenuItem.DropDown is ToolStripDropDownMenu subDropDown)
                {
                    subDropDown.BackColor = MenuFondo;
                    subDropDown.ForeColor = MenuTexto;
                    subDropDown.Renderer = new ToolStripProfessionalRenderer(new EstiloMenu());
                }

                AplicarEstiloMenuItem(subMenuItem); // Recursivo
            }
        }
    }

    private static GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();
        return path;
    }

    private class EstiloMenu : ProfessionalColorTable
    {
        public override Color MenuItemSelected => ColorTranslator.FromHtml("#495057");
        public override Color MenuItemBorder => Color.Transparent;
        public override Color ToolStripDropDownBackground => MenuFondo;
        public override Color MenuItemSelectedGradientBegin => ColorTranslator.FromHtml("#495057");
        public override Color MenuItemSelectedGradientEnd => ColorTranslator.FromHtml("#495057");
        public override Color MenuItemPressedGradientBegin => MenuFondo;
        public override Color MenuItemPressedGradientEnd => MenuFondo;

        public override Color ImageMarginGradientBegin => MenuFondo;
        public override Color ImageMarginGradientMiddle => MenuFondo;
        public override Color ImageMarginGradientEnd => MenuFondo;
        public override Color ImageMarginRevealedGradientBegin => MenuFondo;
        public override Color ImageMarginRevealedGradientMiddle => MenuFondo;
        public override Color ImageMarginRevealedGradientEnd => MenuFondo;
    }
}
