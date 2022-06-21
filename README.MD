# Step 1: create a c# project 

```
dotnet new classlib --name "Tkvw.Lang" -o dotnet/src/Tkvw.Lang
cd dotnet 
git init . 
dotnet new gitignore
git checkout -b develop
git add .
git commit -m "initial commit"
git add .
git commit -m "Added README.MD"
```

# Step 2: add a solution file

```
dotnet new sln --name Tkvw
dotnet sln add .\src\Tkvw.Lang\Tkvw.Lang.csproj
git add .
git commit -m "Added solution file"
```

# Step 3: install global csharp tools if needed

```shell
dotnet tool install Nuke.GlobalTool --global # nuke build
dotnet tool install --global GitVersion.Tool --version 5.* # https://gitversion.net/docs/usage/cli/installation
```

# Step 4: add a build project

```shell
git checkout -b feature/nuke.build
git remote add origin git@github.com:tkvw/dotnet.git # Nuke needs a remote to work 
nuke :setup
nuke :add-package GitVersion.Tool
```