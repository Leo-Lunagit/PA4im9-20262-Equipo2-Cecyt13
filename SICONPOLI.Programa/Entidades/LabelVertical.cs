using System;
using System.Drawing;
using System.Windows.Forms;

public class LabelVertical : Control
{
    public LabelVertical()
    {
        // Optimiza el dibujo para evitar el parpadeo
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.BackColor = Color.Transparent;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Mejorar la calidad del texto rotado para que no se vea pixelado
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        // Guardar el estado actual del lienzo para no afectar otros dibujos
        System.Drawing.Drawing2D.GraphicsState estadoOriginal = e.Graphics.Save();

        // 1. Mover el punto de origen (0,0) a la esquina inferior izquierda del control
        e.Graphics.TranslateTransform(0, this.Height);
        // 2. Rotar el lienzo -90 grados (hacia la izquierda)
        e.Graphics.RotateTransform(-90);

        // Configurar la alineación
        StringFormat formato = new StringFormat();
        formato.Alignment = StringAlignment.Far;
        formato.LineAlignment = StringAlignment.Center;

        using (Brush brocha = new SolidBrush(this.ForeColor))
        {
            // Ejes invertidos (-90), ancho deve ser alto y alto deve ser ancho.
            Rectangle rectanguloDibujo = new Rectangle(0, 0, this.Height, this.Width);
            e.Graphics.DrawString(this.Text, this.Font, brocha, rectanguloDibujo, formato);
        }

        // Restaurar el lienzo a su estado original
        e.Graphics.Restore(estadoOriginal);
    }
    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        this.Invalidate(); // Fuerza al control a repintarse inmediatamente
    }
}