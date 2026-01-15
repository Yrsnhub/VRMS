using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace VRMS.UI.Controls.Rental_ReservationCalendar
{
    public partial class CalendarView : UserControl
    {
        // ===============================
        // LAYOUT CONSTANTS
        // ===============================
        private const int DayColumnWidth = 40;
        private const int RowHeight = 40;
        private const int HeaderHeight = 40;

        // ===============================
        // STATE
        // ===============================
        private DateTime _currentMonth;

        public CalendarView()
        {
            InitializeComponent();

            _currentMonth = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                1
            );

            dtpMonthYear.Value = _currentMonth;

            EnableDoubleBuffering();
        }

        // ===============================
        // DOUBLE BUFFERING (NO FLICKER)
        // ===============================
        private void EnableDoubleBuffering()
        {
            typeof(Panel)
                .GetProperty(
                    "DoubleBuffered",
                    BindingFlags.Instance | BindingFlags.NonPublic
                )
                ?.SetValue(pnlCalendarCanvas, true);
        }

        // ===============================
        // DESIGNER-WIRED EVENTS
        // ===============================
        private void pnlCalendarCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            DrawDayHeaders(g);
            DrawGrid(g);
        }

        private void pnlCalendarCanvas_Resize(object sender, EventArgs e)
        {
            pnlCalendarCanvas.Invalidate();
        }

        // ===============================
        // DRAWING
        // ===============================
        private void DrawDayHeaders(Graphics g)
        {
            int daysInMonth = DateTime.DaysInMonth(
                _currentMonth.Year,
                _currentMonth.Month
            );

            using (Brush headerBrush = new SolidBrush(Color.FromArgb(240, 240, 240)))
            using (Pen borderPen = new Pen(Color.LightGray))
            {
                for (int day = 1; day <= daysInMonth; day++)
                {
                    int x = (day - 1) * DayColumnWidth;

                    Rectangle rect = new Rectangle(
                        x,
                        0,
                        DayColumnWidth,
                        HeaderHeight
                    );

                    g.FillRectangle(headerBrush, rect);
                    g.DrawRectangle(borderPen, rect);

                    DateTime date = new DateTime(
                        _currentMonth.Year,
                        _currentMonth.Month,
                        day
                    );

                    string text = date.ToString("ddd") + "\n" + day;

                    TextRenderer.DrawText(
                        g,
                        text,
                        Font,
                        rect,
                        Color.Black,
                        TextFormatFlags.HorizontalCenter |
                        TextFormatFlags.VerticalCenter |
                        TextFormatFlags.WordBreak
                    );
                }
            }
        }

        private void DrawGrid(Graphics g)
        {
            int daysInMonth = DateTime.DaysInMonth(
                _currentMonth.Year,
                _currentMonth.Month
            );

            int totalHeight = pnlCalendarCanvas.Height;
            int totalWidth = daysInMonth * DayColumnWidth;

            using (Pen pen = new Pen(Color.LightGray))
            {
                // Vertical day lines
                for (int i = 0; i <= daysInMonth; i++)
                {
                    int x = i * DayColumnWidth;
                    g.DrawLine(pen, x, HeaderHeight, x, totalHeight);
                }

                // Horizontal vehicle rows (placeholder)
                for (int y = HeaderHeight; y < totalHeight; y += RowHeight)
                {
                    g.DrawLine(pen, 0, y, totalWidth, y);
                }
            }
        }
    }
}
