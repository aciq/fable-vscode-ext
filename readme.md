# fable vscode extension template

opinionated F# vscode extension template

by opinionated i mean:
- removed paket 
- removed fake
- removed yarn 
- removed webpack
- updated launch.json
- updated fable version
- added fable promise, node and jsonprovider packages by default


## setup

```
npm i
npm run install
```

## debugging

start the fable compiler in watch mode with
```
npm run start 
```
then debug the extension from vscode

then run the command: `newext: helloworld`

