using creamU_API.Entities;
//using Microsoft.EntityFrameworkCore;
//using MySql.EntityFrameworkCore.Extensions;

//using creamU_API.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//�[�J�o�q�]�w�A�N�i�H�b Controller ���غc�禡�`�J����
builder.Services.AddEntityFrameworkMySQL().AddDbContext<CreamUDBContext>(options => {
    //CreamUDBConnection �O�����b appsettings.json �����s�u�r��W��
    options.UseMySQL(builder.Configuration.GetConnectionString("CreamUDB"));
});

//CORS ���]�w
builder.Services.AddCors(options =>
{//���}��A�}��s�u�ӷ��A�}��Ҧ���k(GET POST...��)�A�}��Header�T��
    //�`�N�O�_�����Y�Ԧw�����g�k
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
//�n��b�o��m�A�קK�U�@���٨S���J��ƴN������

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
