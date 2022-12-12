module Main

open Fable.Import.VSCode.Vscode
open Microsoft.FSharp.Core
let vslib = Fable.Import.VSCode.vscode
module vscode = Fable.Import.VSCode.Vscode
    
let helloworld (editor: TextEditor) (_: TextEditorEdit) (_: ResizeArray<obj option>) =
    promise {
        let thenable = vscode.window.showInformationMessage "hello world"
        ()
    }
    |> ignore    


let activate (context: ExtensionContext) =
    let test = 1
    [
        commands.registerTextEditorCommand ("newext.helloworld", helloworld)
    ]
    |> List.map unbox
    |> List.iter context.subscriptions.Add
