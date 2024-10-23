# Installation

Go to `TestNodeApp` and run `npm/yarn install`

# Running

Go to `AspireStopBug.AppHost` and run `dotnet run`

# Bug

* Stop the app host by pressing `Ctrl+c` in the terminal
* In powershell run `Get-Process *aspire*`. Note that there is still running proccesses
* Manually kill the node processes with `Get-Process *node* | Stop-Process`
* Note that the C# processes are now stopped.
