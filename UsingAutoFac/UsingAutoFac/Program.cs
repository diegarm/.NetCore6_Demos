// See https://aka.ms/new-console-template for more information

using Autofac;
using UsingAutoFac;

var containerBuild = new ContainerBuilder();
containerBuild.RegisterModule<ProgramModule>();


var container = containerBuild.Build();
var userService = container.Resolve<UserService>();

var userOld = new User("Diego Armando");
var userNew = new User("Diego Bento");

userService.ChangeUserName(userOld,userNew);

Console.ReadKey();


