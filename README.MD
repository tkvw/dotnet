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