using System.Data;
using free.src.DesignPatterns.Behavioral.Command.RemoteControl;
using free.src.DesignPatterns.Behavioral.Command.Undoable;
using free.src.DesignPatterns.Behavioral.State;
using free.src.DesignPatterns.Behavioral.Strategy;
// State
// var doc = new Document(UserRoles.Admin);

// Console.WriteLine(doc.state);

// doc.Publish();

// Console.WriteLine(doc.state);

// doc.Publish();

// Console.WriteLine(doc.state);

// Strategy
// var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
// videoStorage.Store("/videos/some-movie");

// // Command Remote Control
// var light = new Light();
// var remote = new RemoteControl(new TurnOnCommand(light));
// remote.PressButton();

//Command Undoable
var htmlDoc = new HtmlDocument();
var history = new History();
htmlDoc.Content = "Hello world";
Console.WriteLine(htmlDoc.Content);

var italicCommand = new ItalicCommand(htmlDoc, history);
italicCommand.Execute();
Console.WriteLine(htmlDoc.Content);

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
Console.WriteLine(htmlDoc.Content);

