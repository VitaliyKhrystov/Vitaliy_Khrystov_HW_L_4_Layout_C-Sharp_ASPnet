namespace Task_1
{
    public class Program
    {

        //Задание 1 (Additional Task)
        //Подключите библиотеку bootstrap.
        //Используя bootstrap сделайте меню https://getbootstrap.com/docs/4.3/components/navbar/
        //Меню должно содержать 3 пункта «Главная», «Страница 1», «Страница 2».
        //Каждый пункт должен вести на отдельное представление с уникальным сообщением. 
        //Используя компоновки сделайте меню доступным на каждом представлении.

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}