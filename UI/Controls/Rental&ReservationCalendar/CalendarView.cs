using System;
using System.Collections.Generic;
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
        private const int HourRowHeight = 60;
        private const int TimeColumnWidth = 60;
        private const int DayStartHour = 8;   // 8 AM
        private const int DayEndHour = 20;    // 8 PM

        // ===============================
        // ENUMS
        // ===============================
        public enum CalendarViewMode
        {
            Month,
            Week
        }

        // ===============================
        // STATE
        // ===============================
        private DateTime _currentDate;
        private CalendarViewMode _currentViewMode = CalendarViewMode.Month;

        // ===============================
        // DUMMY RENTAL MODEL
        // ===============================
        private class DummyRental
        {
            public int VehicleRow { get; set; }   // row index
            public int StartDay { get; set; }     // day of month
            public int Duration { get; set; }     // days long
            public string Customer { get; set; }
            public Color Color { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }

        // ===============================
        // DUMMY DATA
        // ===============================
        private readonly List<DummyRental> _dummyRentals = new()
        {
            // Monthly view rentals
            new DummyRental { VehicleRow = 0, StartDay = 2,  Duration = 3, Customer = "Juan D.", Color = Color.SkyBlue },
            new DummyRental { VehicleRow = 1, StartDay = 5,  Duration = 4, Customer = "Maria S.", Color = Color.LightGreen },
            new DummyRental { VehicleRow = 2, StartDay = 1,  Duration = 2, Customer = "Alex R.", Color = Color.Khaki },
            new DummyRental { VehicleRow = 3, StartDay = 10, Duration = 5, Customer = "Chris T.", Color = Color.Plum },
            new DummyRental { VehicleRow = 4, StartDay = 8,  Duration = 3, Customer = "Liam K.", Color = Color.LightSalmon },
            
            // Weekly view rentals (with time information)
            new DummyRental {
                VehicleRow = 0,
                StartTime = DateTime.Today.AddDays(1).AddHours(9),
                EndTime = DateTime.Today.AddDays(1).AddHours(11),
                Customer = "Morning Rental",
                Color = Color.SkyBlue
            },
            new DummyRental {
                VehicleRow = 1,
                StartTime = DateTime.Today.AddDays(2).AddHours(14),
                EndTime = DateTime.Today.AddDays(2).AddHours(16),
                Customer = "Afternoon Slot",
                Color = Color.LightGreen
            },
            new DummyRental {
                VehicleRow = 2,
                StartTime = DateTime.Today.AddDays(0).AddHours(10),
                EndTime = DateTime.Today.AddDays(0).AddHours(12),
                Customer = "Today's Booking",
                Color = Color.Khaki
            },
            new DummyRental {
                VehicleRow = 3,
                StartTime = DateTime.Today.AddDays(3).AddHours(8),
                EndTime = DateTime.Today.AddDays(3).AddHours(10),
                Customer = "Early Morning",
                Color = Color.Plum
            }
        };

        public CalendarView()
        {
            InitializeComponent();

            _currentDate = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                DateTime.Today.Day
            );

            dtpMonthYear.Value = _currentDate;
            dtpWeekView.Value = _currentDate;

            SetViewMode(CalendarViewMode.Month);
            EnableDoubleBuffering();
        }

        // ===============================
        // VIEW MODE MANAGEMENT
        // ===============================
        private void SetViewMode(CalendarViewMode mode)
        {
            _currentViewMode = mode;

            // Update button states
            if (mode == CalendarViewMode.Month)
            {
                btnMonthView.BackColor = Color.SteelBlue;
                btnMonthView.ForeColor = Color.White;
                btnWeekView.BackColor = SystemColors.Control;
                btnWeekView.ForeColor = SystemColors.ControlText;

                dtpMonthYear.Visible = true;
                dtpWeekView.Visible = false;

                // Set to first day of month
                _currentDate = new DateTime(_currentDate.Year, _currentDate.Month, 1);
                dtpMonthYear.Value = _currentDate;
            }
            else // Week view
            {
                btnWeekView.BackColor = Color.SteelBlue;
                btnWeekView.ForeColor = Color.White;
                btnMonthView.BackColor = SystemColors.Control;
                btnMonthView.ForeColor = SystemColors.ControlText;

                dtpMonthYear.Visible = false;
                dtpWeekView.Visible = true;

                // Set to Monday of current week
                _currentDate = GetStartOfWeek(_currentDate);
                dtpWeekView.Value = _currentDate;
            }

            pnlCalendarCanvas.Invalidate();
        }

        private DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        private DateTime GetEndOfWeek(DateTime date)
        {
            return GetStartOfWeek(date).AddDays(6);
        }

        // ===============================
        // EVENT HANDLERS
        // ===============================
        private void btnMonthView_Click(object sender, EventArgs e)
        {
            SetViewMode(CalendarViewMode.Month);
        }

        private void btnWeekView_Click(object sender, EventArgs e)
        {
            SetViewMode(CalendarViewMode.Week);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentViewMode == CalendarViewMode.Month)
            {
                _currentDate = _currentDate.AddMonths(-1);
                dtpMonthYear.Value = _currentDate;
            }
            else // Week view
            {
                _currentDate = _currentDate.AddDays(-7);
                dtpWeekView.Value = _currentDate;
            }
            pnlCalendarCanvas.Invalidate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentViewMode == CalendarViewMode.Month)
            {
                _currentDate = _currentDate.AddMonths(1);
                dtpMonthYear.Value = _currentDate;
            }
            else // Week view
            {
                _currentDate = _currentDate.AddDays(7);
                dtpWeekView.Value = _currentDate;
            }
            pnlCalendarCanvas.Invalidate();
        }

        private void dtpMonthYear_ValueChanged(object sender, EventArgs e)
        {
            _currentDate = dtpMonthYear.Value;
            pnlCalendarCanvas.Invalidate();
        }

        private void dtpWeekView_ValueChanged(object sender, EventArgs e)
        {
            _currentDate = GetStartOfWeek(dtpWeekView.Value);
            pnlCalendarCanvas.Invalidate();
        }

        // ===============================
        // DOUBLE BUFFERING
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
        // PAINT EVENTS
        // ===============================
        private void pnlCalendarCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            switch (_currentViewMode)
            {
                case CalendarViewMode.Month:
                    DrawMonthView(g);
                    break;
                case CalendarViewMode.Week:
                    DrawWeekView(g);
                    break;
            }
        }

        private void pnlCalendarCanvas_Resize(object sender, EventArgs e)
        {
            pnlCalendarCanvas.Invalidate();
        }

        // ===============================
        // MONTH VIEW DRAWING
        // ===============================
        private void DrawMonthView(Graphics g)
        {
            int daysInMonth = DateTime.DaysInMonth(
                _currentDate.Year,
                _currentDate.Month
            );

            DrawDayHeaders(g, daysInMonth);
            DrawGrid(g, daysInMonth);
           
        }

        private void DrawDayHeaders(Graphics g, int daysInMonth)
        {
            using Brush headerBrush = new SolidBrush(Color.FromArgb(240, 240, 240));
            using Pen borderPen = new Pen(Color.LightGray);

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
                    _currentDate.Year,
                    _currentDate.Month,
                    day
                );

                TextRenderer.DrawText(
                    g,
                    $"{date:ddd}\n{day}",
                    Font,
                    rect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.WordBreak
                );
            }
        }

        private void DrawGrid(Graphics g, int daysInMonth)
        {
            int totalHeight = pnlCalendarCanvas.Height;
            int totalWidth = daysInMonth * DayColumnWidth;

            using Pen pen = new Pen(Color.LightGray);

            // Vertical day lines
            for (int i = 0; i <= daysInMonth; i++)
            {
                int x = i * DayColumnWidth;
                g.DrawLine(pen, x, HeaderHeight, x, totalHeight);
            }

            // Horizontal rows
            for (int y = HeaderHeight; y < totalHeight; y += RowHeight)
            {
                g.DrawLine(pen, 0, y, totalWidth, y);
            }
        }

        private void DrawMonthRentals(Graphics g)
        {
            using Pen borderPen = new Pen(Color.DimGray);

            foreach (var rental in _dummyRentals)
            {
                if (rental.StartDay == 0) continue; // Skip weekly rentals

                int x = (rental.StartDay - 1) * DayColumnWidth;
                int y = HeaderHeight + rental.VehicleRow * RowHeight;
                int width = rental.Duration * DayColumnWidth;
                int height = RowHeight - 6;

                Rectangle rect = new Rectangle(
                    x + 2,
                    y + 3,
                    width - 4,
                    height
                );

                using Brush fillBrush = new SolidBrush(rental.Color);
                g.FillRectangle(fillBrush, rect);
                g.DrawRectangle(borderPen, rect);

                TextRenderer.DrawText(
                    g,
                    rental.Customer,
                    Font,
                    rect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.EndEllipsis
                );
            }
        }

        // ===============================
        // WEEK VIEW DRAWING
        // ===============================
        private void DrawWeekView(Graphics g)
        {
            DateTime startOfWeek = GetStartOfWeek(_currentDate);

            DrawWeekTimeHeaders(g, startOfWeek);
            DrawWeekGrid(g);
            DrawWeekRentals(g, startOfWeek);
        }

        private void DrawWeekTimeHeaders(Graphics g, DateTime startOfWeek)
        {
            using Brush timeHeaderBrush = new SolidBrush(Color.FromArgb(240, 240, 240));
            using Brush dayHeaderBrush = new SolidBrush(Color.FromArgb(220, 220, 220));
            using Pen borderPen = new Pen(Color.LightGray);

            // Time column header
            Rectangle timeHeaderRect = new Rectangle(0, 0, TimeColumnWidth, HeaderHeight);
            g.FillRectangle(timeHeaderBrush, timeHeaderRect);
            g.DrawRectangle(borderPen, timeHeaderRect);

            // Day headers
            for (int day = 0; day < 7; day++)
            {
                DateTime currentDay = startOfWeek.AddDays(day);
                int x = TimeColumnWidth + (day * ((pnlCalendarCanvas.Width - TimeColumnWidth) / 7));

                Rectangle dayHeaderRect = new Rectangle(
                    x,
                    0,
                    (pnlCalendarCanvas.Width - TimeColumnWidth) / 7,
                    HeaderHeight
                );

                g.FillRectangle(dayHeaderBrush, dayHeaderRect);
                g.DrawRectangle(borderPen, dayHeaderRect);

                TextRenderer.DrawText(
                    g,
                    $"{currentDay:ddd}\n{currentDay:MMM d}",
                    Font,
                    dayHeaderRect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.WordBreak
                );
            }
        }

        private void DrawWeekGrid(Graphics g)
        {
            int totalHeight = pnlCalendarCanvas.Height;
            int dayWidth = (pnlCalendarCanvas.Width - TimeColumnWidth) / 7;

            using Pen lightPen = new Pen(Color.LightGray);
            using Pen mediumPen = new Pen(Color.Gray);

            // Draw time column
            for (int hour = DayStartHour; hour <= DayEndHour; hour++)
            {
                int y = HeaderHeight + ((hour - DayStartHour) * HourRowHeight);

                // Time labels
                Rectangle timeRect = new Rectangle(0, y, TimeColumnWidth, HourRowHeight);
                g.DrawRectangle(lightPen, timeRect);

                TextRenderer.DrawText(
                    g,
                    $"{hour:00}:00",
                    Font,
                    timeRect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter
                );

                // Horizontal lines across days
                g.DrawLine(lightPen, TimeColumnWidth, y, pnlCalendarCanvas.Width, y);
            }

            // Draw vertical day separators
            for (int day = 0; day <= 7; day++)
            {
                int x = TimeColumnWidth + (day * dayWidth);
                g.DrawLine(mediumPen, x, HeaderHeight, x, totalHeight);
            }
        }

        private void DrawWeekRentals(Graphics g, DateTime startOfWeek)
        {
            using Pen borderPen = new Pen(Color.DimGray);
            int dayWidth = (pnlCalendarCanvas.Width - TimeColumnWidth) / 7;

            foreach (var rental in _dummyRentals)
            {
                if (rental.StartTime == DateTime.MinValue) continue; // Skip monthly rentals

                // Check if rental is in current week
                if (rental.StartTime.Date < startOfWeek || rental.StartTime.Date > startOfWeek.AddDays(6))
                    continue;

                // Calculate position
                int dayIndex = (int)(rental.StartTime.Date - startOfWeek.Date).TotalDays;
                int x = TimeColumnWidth + (dayIndex * dayWidth);

                // Calculate vertical position based on time
                double hourFraction = rental.StartTime.Hour + (rental.StartTime.Minute / 60.0);
                double durationHours = (rental.EndTime - rental.StartTime).TotalHours;

                int y = HeaderHeight + (int)((hourFraction - DayStartHour) * HourRowHeight);
                int height = (int)(durationHours * HourRowHeight);

                Rectangle rect = new Rectangle(
                    x + 2,
                    y + 2,
                    dayWidth - 4,
                    height - 4
                );

                using Brush fillBrush = new SolidBrush(rental.Color);
                g.FillRectangle(fillBrush, rect);
                g.DrawRectangle(borderPen, rect);

                // Draw rental info
                string timeText = $"{rental.StartTime:HH:mm} - {rental.EndTime:HH:mm}";
                string displayText = $"{rental.Customer}\n{timeText}";

                TextRenderer.DrawText(
                    g,
                    displayText,
                    new Font(Font.FontFamily, 8),
                    rect,
                    Color.Black,
                    TextFormatFlags.HorizontalCenter |
                    TextFormatFlags.VerticalCenter |
                    TextFormatFlags.WordBreak
                );
            }
        }

        // Add these event handlers to the constructor after InitializeComponent()
       
    }
}