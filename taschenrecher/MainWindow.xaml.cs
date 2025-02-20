namespace AdvancedCalculator
{
    public partial class HistoryWindow : Window
    {
        public HistoryWindow(List<string> history)
        {
            InitializeComponent();
            historyListBox.ItemsSource = history;
        }
    }
}
