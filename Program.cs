using creamU_API.Entities;
//using Microsoft.EntityFrameworkCore;
//using MySql.EntityFrameworkCore.Extensions;

//using creamU_API.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//加入這段設定，就可以在 Controller 的建構函式注入物件
builder.Services.AddEntityFrameworkMySQL().AddDbContext<CreamUDBContext>(options => {
    //CreamUDBConnection 是紀錄在 appsettings.json 中的連線字串名稱
    options.UseMySQL(builder.Configuration.GetConnectionString("CreamUDB"));
});

//CORS 的設定
builder.Services.AddCors(options =>
{//全開放，開放連線來源，開放所有方法(GET POST...等)，開放Header訊息
    //注意是否有更嚴謹安全的寫法
    options.AddPolicy("AllowAll", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
//要放在這位置，避免下一行還沒載入資料就先報錯

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
