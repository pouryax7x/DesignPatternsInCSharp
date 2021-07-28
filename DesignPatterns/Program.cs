using System;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.AvaFilter;
using DesignPatterns.Bridge;
using DesignPatterns.ChainOfResposibility;
using DesignPatterns.Command;
using DesignPatterns.Command.Editor;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.FlyWeight;
using DesignPatterns.Iterator;
using DesignPatterns.Mediator;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.Observer.Pull;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Template;
using DesignPatterns.Visitor;
using Button = DesignPatterns.Command.FrameWork.Button;
using Compressor = DesignPatterns.ChainOfResposibility.Compressor;
using History = DesignPatterns.Memento.History;
using HtmlDocument = DesignPatterns.Command.Editor.HtmlDocument;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Memento
            var editor = new Editor();
            var history = new History();
            editor.Content = "a";
            history.Push(editor.CreateState());
            editor.Content = "b";
            history.Push(editor.CreateState());
            editor.Content = "c";
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            //State
            Canvas canvas = new Canvas();
            canvas.CurrenctTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();
            canvas.CurrenctTool = new EraserTool();
            canvas.MouseDown();
            canvas.MouseUp();

            //Iterator
            BrowseHistory browseHistory = new BrowseHistory();
            var iterator = browseHistory.CreateIterator();
            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }

            //Strategy
            var imageStorage = new ImageStorage(
                new JpgCompressor(), new BWFilter());
            imageStorage.Store("A.image");

            //Template
            var task = new TransferMMoneyTask(new AuditTrail());
            task.Execute();

            //Command
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.Click();

            //command 2
            var composite = new CompositeCommand();
            composite.Add(new ResizeCommand());
            composite.Add(new BlackAndWhiteCommand());
            composite.Execute();

            //command 3

            var history2 = new Command.Editor.History();
            var document = new HtmlDocument();
            document.Content = "Hello World";

            var boldCommand = new BoldCommand(document, history2);
            boldCommand.Execute();
            Console.WriteLine(document.Content);

            var undoCommand = new UndoCommand(history2);
            undoCommand.Execute();
            Console.WriteLine(document.Content);

            //Observer Pull
            var dataSource = new DataSource();
            var sheet1 = new SpreardSheet(dataSource);
            var sheet2 = new SpreardSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);
            dataSource.Value = 2;

            //Mediator

            var dialog = new ArticlesDialogbox();
            dialog.simulateUserIntraction();


            //Chain of responsibility

            var compresser = new Compressor(null);
            var logger = new Logger(compresser);
            var authenticator = new Authenticator(logger);
            var server = new WebServer(authenticator);

            server.Handle(new HttpRequest("admin", "1234"));


            //Visitor

            var document2 = new DesignPatterns.Visitor.HtmlDocument();
            document2.Add(new AnchorNode());
            document2.Add(new HeadingNode());
            document2.Execute(new HighlightOperation());
            document2.Execute(new PlainTextOperation());

            //Composite

            var group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());

            var group2 = new Group();
            group2.Add(new Shape());
            group2.Add(new Shape());

            var group = new Group();

            group.Add(group1);
            group.Add(group2);
            group.Render();
            group.Move();

            //Adaptor
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelFilter(new Caramel()));

            //Decorator

            var cloudstream = new EncyptedCloudStream(new CloudStream());
            cloudstream.Write("here is some data");

            //Facade

            var notificationService = new NotificationService();
            notificationService.Send("hi" , "target");

            //FlyWeight

            var service2 = new PointService(new PointIconFactory());
            foreach (var point in service2.GetPoints())
            {
                point.draw();
            }

            //Bridge

            var remoteControl = new AdvancedRemoteControl(new SonyTV());
            var remoteControl1 = new RemoteControl(new SonyTV());
            remoteControl.TurnOn();
        }
    }
}
