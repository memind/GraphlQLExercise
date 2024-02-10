using GraphiQl;
using GraphlQLExercise.Data;
using GraphlQLExercise.GraphQL.Mutation;
using GraphlQLExercise.GraphQL.Query;
using GraphlQLExercise.GraphQL.Schemas;
using GraphlQLExercise.GraphQL.Type;
using GraphlQLExercise.Interfaces;
using GraphlQLExercise.Services;
using GraphQL;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IReservationRepository, ReservationRepository>();

builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<CategoryType>();
builder.Services.AddTransient<ReservationType>();

builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<CategoryQuery>();
builder.Services.AddTransient<ReservationQuery>();
builder.Services.AddTransient<RootQuery>();

builder.Services.AddTransient<MenuMutation>();
builder.Services.AddTransient<ReservationMutation>();
builder.Services.AddTransient<CategoryMutation>();
builder.Services.AddTransient<RootMutation>();


builder.Services.AddTransient<MenuInputType>();
builder.Services.AddTransient<CategoryInputType>();
builder.Services.AddTransient<ReservationInputType>();

builder.Services.AddTransient<ISchema, RootSchema>();

builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

builder.Services.AddDbContext<GraphQLDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();