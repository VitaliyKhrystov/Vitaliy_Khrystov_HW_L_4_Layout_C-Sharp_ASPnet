namespace Task3
{
    public class Program
    {

        //Задание 2
        //Создайте веб приложение, в котором будут использоваться вложенные компоновки.
        //Сделайте так, чтобы при переходе на представление «Страница 2» (из задания из раздела
        //«дополнительное задание») у Вас в представлении отображалось меню слева, дополнительно
        //к основному меню.При этом, в левом меню должно быть три пункта – Меню 1, Меню 2, Меню 3,
        //каждый пункт будет вести на отдельное представление с уникальным текстом. На всех этих
        //представлениях должно отображаться как левое меню, так и основное меню.

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