
namespace MauiApp1
{
	public partial class MainPage : ContentPage
	{
		public IList<TestItem> Items { get; set; }

		public MainPage()
		{
			BindingContext = this;
			InitializeComponent();
			Items = new List<TestItem>();
			Items.Add(new TestItem() { Name = "testItem1" });
			//Items.Add(new TestItem() { Name = "testItem2"});
			collection.ItemsSource = Items;

		}

		public class TestItem
		{
			public string? Name { get; set; }
		}
	}
}
