using ElmSharp;
using Tizen.NET.MaterialComponents;

namespace MaterialGallery
{
    class MModalSideSheetsPage : BaseGalleryPage
    {
        public override string Name => "MModalSideSheets Gallery";

        public override bool RunningOnNewWindow => true;

        MConformant _conformant;

        public override Conformant CreateComformant(Window window)
        {
            _conformant = new MConformant(window);
            _conformant.Show();
            return _conformant;
        }

        public override EvasObject CreateContent(EvasObject parent)
        {
            if (_conformant == null)
                return null;

            Box box = new ColoredBox(parent);
            box.Show();

            #region ModalSheets
            MModalSheets modalSheets = new MModalSheets(_conformant, MModalSheetsDirection.Side);
            modalSheets.Show();

            Label label1 = new Label(parent)
            {
                Text = "<span font_size=35 color=#a8a8a8>Labels</span>",
                AlignmentX = 0,
            };
            label1.Show();
            var check1 = new MCheckBox(parent)
            {
                Text = "Events",
                MinimumWidth = 400,
            };
            check1.Show();
            var check2 = new MCheckBox(parent)
            {
                Text = "Personal",
                IsChecked = true,
                MinimumWidth = 400,
            };
            check2.Show();
            var check3 = new MCheckBox(parent)
            {
                Text = "Project",
                IsChecked = true,
                MinimumWidth = 400,
            };
            check3.Show();
            var check4 = new MCheckBox(parent)
            {
                Text = "Reminders",
                MinimumWidth = 400,
            };
            check4.Show();
            var check5 = new MCheckBox(parent)
            {
                Text = "Work",
                MinimumWidth = 400,
            };
            check5.Show();

            var contents = new Box(_conformant)
            {
                IsHorizontal = true,
                AlignmentX = -1,
                AlignmentY = -1,
                WeightX = 1,
                WeightY = 1,
                BackgroundColor = Color.White,
            };
            contents.Show();
            contents.SetPadding(45, 45);

            var contents1 = new Box(_conformant)
            {
                IsHorizontal = true,
            };
            contents1.Show();
            contents1.SetPadding(45, 45);
            contents.PackEnd(contents1);

            var contents2 = new Box(_conformant)
            {
                IsHorizontal = false,
                AlignmentX = 0,
                AlignmentY = 0,
                WeightX = 1,
                WeightY = 0,
            };
            contents2.Show();
            contents2.SetPadding(45, 45);
            contents.PackEnd(contents2);

            var contents3 = new Box(_conformant)
            {
                IsHorizontal = false,
            };
            contents3.Show();
            contents3.SetPadding(45, 45);
            contents2.PackEnd(contents3);

            contents2.PackEnd(label1);
            contents2.PackEnd(check1);
            contents2.PackEnd(check2);
            contents2.PackEnd(check3);
            contents2.PackEnd(check4);
            contents2.PackEnd(check5);

            modalSheets.SetContent(contents);
            #endregion

            #region Buttons
            Box btbox = new Box(parent)
            {
                WeightX = 1,
                WeightY = 0.3,
                AlignmentX = -1,
                AlignmentY = -1,
            };
            btbox.Show();
            box.PackEnd(btbox);

            MButton button1 = new MButton(parent)
            {
                Text = "Open MModalSideSheets",
                MinimumWidth = 600,
                AlignmentY = 0,
                WeightY = 0.3,
            };
            button1.Show();
            button1.Clicked += (s, e) =>
            {
                modalSheets.IsOpen = true;
            };

            btbox.PackEnd(button1);
            #endregion

            return box;
        }
    }
}
