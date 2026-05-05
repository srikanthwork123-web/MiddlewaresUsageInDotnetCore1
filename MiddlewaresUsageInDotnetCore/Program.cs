//this program.cs is divided into 2 sections.
//===========================================================
//section1:builder is the inbuilt depency injection conatiner.we need to register our all application depencies into our inbuilt depency injection container.
//================================================================================================================================================================
//this conatiner will load your depencies and then it will inject those depencies to the controller class by using constructor injection and then we can use those depencies in the controller class to perform the required operations.


#region inbuilt dependency injection containerSection.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder is the inbuilt dependency injection container which is used to register the services and the repositories in the dependency injection container of the application and then we are building the application and running it.
//if you run the program,first it will call program.cs and it will load all the depencies into the memory and then it will inject those depencies to the controller class by using constructor injection and then we can use those depencies in the controller class to perform the required operations
// If you want to add any depencencies to your  container. by using builder.services....we can register our dependicies.
#endregion


//section2:app is the inbuilt request pipeline,heare we need to register our middlewares to application pipeline.
//===================================================================================================================
#region inbuilt request pipelineSection

var app = builder.Build();//this is one request pipeline,whenever we run the application,first it will call program.cs and it will create the request pipeline.
//all middleware we need to configure/register /adding to this request pipeline
//whenever if you add any middleware to request pipeleine order wise it will exceute.
// middleware naming convention starts with use keyword.
//====================This is one middleware ..we can create n no of middlewares as per our requirment
//here we are adding the inline middleware to the request pipeline by using app.use() method and we are writing the logic of the middleware inside the app.use() method.
//whatever the order we register the middleware in the request pipeline same order it will execute,if any middleware executes successfully it will pass the request to next middleware,if its fail/Shortcurit it will stop the middleware execution and throwing the error.
app.Use(async (context, next) => {//app.Use for Inline middlewares,write all logic inside the method,this is called inline middleware.
    await context.Response.WriteAsync("Hello I am From user9");
    await next.Invoke();//next will call the next middleware
});

//Use method add a middleware to the request pipeline.based on order you registered to request paipeleine.
//it will exceute same order.
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user2");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user3");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user4");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user5");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user6");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user7");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user8");
    await next.Invoke();//next will call the next middleware
});
app.Use(async (context, next) => {//app.Use for Inline middlewares
    await context.Response.WriteAsync("Hello I am From user1");
    await next.Invoke();//next will call the next middleware
});



app.Run();
#endregion

/*
 1.What is Middleware? how  many Ways we create the middleware's ?
A)=>Middleware process Request and Response to the Application pipeline.
Middleware executed in Sequence order.
Whatever order you register  in the application pipeline same order it will execute
=>if middleware executes successfully it will pass the request to next middleware.if its fail/Shortcurit it will stop the middleware execution and throwing the error.
=>all middlewares we need to register in the program.cs having a inbuilt request pipeline is there,that is called "app".in this app we need to register our middlewares to application pipeline.middleware naming convestion Starts with use keyword.
=>we can create the middlewares 2 ways.
1)inline middleware.
2)custom middleware.
================
1)inline middleware:
====================
=>inline middleware is a simple way to create the middleware.
we can create the inline middleware in program.cs file.
we can create the inline middleware by using app.use() method.
we can write the logic of the middleware inside the app.use() method.
*/