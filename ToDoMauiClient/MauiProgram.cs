using Microsoft.Extensions.Logging;
using ToDoMauiClient.DataServices;
using ToDoMauiClient.Pages;

namespace ToDoMauiClient;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
				fonts.AddFont("Sit.ttf", "Stika");

			});


		builder.Services.AddSingleton<IRestDataService, RestDataService>();
		builder.Services.AddTransient<ManageToDoPage>();

		return builder.Build();
	}
}
