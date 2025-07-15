using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaBSG.Resources.Colors
{
    public static class LigthMode
    {

        // 🎨 Colores estilo Bootstrap 5 Light
        public static Color FondoFormulario = ColorTranslator.FromHtml("#FFFFFF");
        public static Color TextoPrincipal = ColorTranslator.FromHtml("#212529");
        public static Color BotonFondo = ColorTranslator.FromHtml("#0D6EFD");
        public static Color BotonTexto = ColorTranslator.FromHtml("#FFFFFF");
        public static Color BotonHover = ColorTranslator.FromHtml("#0B5ED7");
        public static Color CampoFondo = ColorTranslator.FromHtml("#F8F9FA");
        public static Color Borde = ColorTranslator.FromHtml("#CED4DA");
        public static Color MenuFondo = ColorTranslator.FromHtml("#E9ECEF");
        public static Color MenuTexto = ColorTranslator.FromHtml("#212529");

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
                    txt.BackColor = Color.White;
                    txt.ForeColor = TextoPrincipal;
                    txt.BorderStyle = BorderStyle.None;
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
                    tabs.ItemSize = new Size(100, 25);
                    tabs.SizeMode = TabSizeMode.Normal;
                    tabs.BackColor = FondoFormulario;
                    tabs.ForeColor = TextoPrincipal;

                    tabs.DrawItem += (s, e) =>
                    {
                        TabControl tab = s as TabControl;
                        bool isSelected = (e.Index == tab.SelectedIndex);
                        Brush backgroundBrush = new SolidBrush(isSelected ? CampoFondo : ColorTranslator.FromHtml("#DEE2E6"));
                        Brush textBrush = new SolidBrush(TextoPrincipal);
                        Rectangle tabBounds = e.Bounds;

                        e.Graphics.FillRectangle(backgroundBrush, tabBounds);
                        e.Graphics.DrawString(tab.TabPages[e.Index].Text, e.Font, textBrush, tabBounds.X + 6, tabBounds.Y + 5);
                    };

                    // Este evento es clave para quitar el fondo blanco
                    tabs.Paint += (s, e) =>
                    {
                        e.Graphics.Clear(FondoFormulario);
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
            menu.Renderer = new ToolStripProfessionalRenderer(new EstiloMenuClaro());
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
            contextMenu.Renderer = new ToolStripProfessionalRenderer(new EstiloMenuClaro());
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
                dropDown.Renderer = new ToolStripProfessionalRenderer(new EstiloMenuClaro());
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
                        subDropDown.Renderer = new ToolStripProfessionalRenderer(new EstiloMenuClaro());
                    }

                    AplicarEstiloMenuItem(subMenuItem); // Recursivo
                }
            }
        }

        private class EstiloMenuClaro : ProfessionalColorTable
        {
            public override Color MenuItemSelected => ColorTranslator.FromHtml("#DEE2E6");
            public override Color MenuItemBorder => Color.Transparent;
            public override Color ToolStripDropDownBackground => MenuFondo;
            public override Color MenuItemSelectedGradientBegin => ColorTranslator.FromHtml("#DEE2E6");
            public override Color MenuItemSelectedGradientEnd => ColorTranslator.FromHtml("#DEE2E6");
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

}
