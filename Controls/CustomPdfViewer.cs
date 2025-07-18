using Patagames.Pdf.Enums;


using Patagames.Pdf.Net.Controls.WinForms;

namespace SignaBSG.Helpers;

public class CustomPdfViewer:PdfViewer
{
    public Cursor CursorPersonalizado { get; set; }
    
    protected override void InternalSetCursor(CursorTypes cursorType)
    {
        if (CursorPersonalizado != null)
        {
            this.Cursor = CursorPersonalizado;
        }
        else
        {
            base.InternalSetCursor(cursorType);
        }
    }

    
}
