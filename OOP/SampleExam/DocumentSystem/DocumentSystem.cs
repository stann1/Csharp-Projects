using System;
using System.Collections.Generic;
using DocumentSystem_1;
using System.Text;

public interface IDocument
{
	string Name { get; }
	string Content { get; }
	void LoadProperty(string key, string value);
	void SaveAllProperties(IList<KeyValuePair<string, object>> output);
	string ToString();
}

public interface IEditable
{
	void ChangeContent(string newContent);
}

public interface IEncryptable
{
	bool IsEncrypted { get; }
	void Encrypt();
	void Decrypt();
}

public class DocumentSystem
{
    private static IList<IDocument> documents = new List<IDocument>();

    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }
  
    private static void AddTextDocument(string[] attributes)
    {
        AddDocument(new TextDocument(), attributes);
    }

    private static void AddPdfDocument(string[] attributes)
    {
        AddDocument(new PDFDocument(), attributes);
    }

    private static void AddWordDocument(string[] attributes)
    {
        AddDocument(new WordDocument(), attributes);
    }

    private static void AddExcelDocument(string[] attributes)
    {
        AddDocument(new ExcelDocument(), attributes);
    }

    private static void AddAudioDocument(string[] attributes)
    {
        AddDocument(new AudioDocument(), attributes);
    }

    private static void AddVideoDocument(string[] attributes)
    {
        AddDocument(new VideoDocument(), attributes);
    }

    //Implemented joint method for adding documents
    private static void AddDocument(IDocument document, string[] attributes)
    {
        foreach (string att in attributes)
        {
            string key = att.Substring(0, att.IndexOf('='));
            string value = att.Substring(att.IndexOf('=') + 1);

            document.LoadProperty(key, value);
        }
        if (document.Name != null)
        {
            documents.Add(document);
            Console.WriteLine("Document added: {0}", document.Name);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void ListDocuments()
    {
        if (documents.Count > 0)
        {
            foreach (var doc in documents)
            {
                Console.WriteLine(doc);
            }
        }
        else
        {
            Console.WriteLine("No documents found");
        }
    }

    private static void EncryptDocument(string name)
    {
        bool foundDoc = false;
        foreach (var doc in documents)
        {
            if (doc.Name == name)
            {
                foundDoc = true;
                
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Encrypt();
                    Console.WriteLine("Document encrypted: {0}", name);
                }
                else
                {
                    Console.WriteLine("Document does not support encryption: {0}", name);
                }
            }            
        }

        if (!foundDoc)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void DecryptDocument(string name)
    {
        bool foundDoc = false;
        foreach (var doc in documents)
        {
            if (doc.Name == name)
            {
                foundDoc = true;

                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Decrypt();
                    Console.WriteLine("Document decrypted: {0}", name);
                }
                else
                {
                    Console.WriteLine("Document does not support decryption: {0}", name);
                }
            }
        }

        if (!foundDoc)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    private static void EncryptAllDocuments()
    {
        bool foundValid = false;

        foreach (var doc in documents)
        {
            if (doc is IEncryptable)
            {
                ((IEncryptable)doc).Encrypt();
                foundValid = true;
            }
        }

        if (foundValid)
        {
            Console.WriteLine("All documents encrypted");
        }
        else
        {
            Console.WriteLine("No encryptable documents found");
        }
    }

    private static void ChangeContent(string name, string content)
    {
        bool docFound = false;

        foreach (var doc in documents)
        {
            if (doc.Name == name)
            {
                docFound = true;

                if (doc is IEditable)
                {
                    ((IEditable)doc).ChangeContent(content);
                    Console.WriteLine("Document content changed: {0}", name);
                }
                else
                {
                    Console.WriteLine("Document is not editable: {0}", name);
                }                
            }
            
        }

        if(!docFound)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

   
}
