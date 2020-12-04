using System;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using System.Collections.Generic;

public class WordFile
{    
    readonly string text;
    public int startOfSearch = 0;
    string beginOfSearchingMask = string.Empty;
    string endOfSearchingMask = string.Empty;

    Word.Application wdApp;
    Word.Document wdDocument;
    Word.Range wdRange;
    Word.Find wdFind;

    object missingObj = Missing.Value;
    object objTrue = (object)true;
    object objFalse = (object)false;

    public WordFile(string path)
    {
        try
        {
            object objPath = (object)path;
            wdApp = new Word.Application();
            wdDocument = wdApp.Documents.Open(ref objPath, ref missingObj, ref objFalse);
        }
        catch
        {
            closeFile();
        }
        finally
        {       
            text = wdDocument.Content.Text;
            beginOfSearchingMask = "[";
            endOfSearchingMask = "]";
        }
    } 

    ~WordFile()
    {
        closeFile();
        colapceApp();
    }

    public void openDoc(string name)
    {
        object objPath = (object)name;
        wdDocument = wdApp.Documents.Open(ref objPath, ref missingObj, ref objFalse);
    }

    public void closeFile()
    {
        wdApp.ActiveDocument.Close();
        //wdDocument.Close();
        //wdDocument = null;
    }

    public void colapceApp()
    {
        wdApp.Quit();
        GC.Collect();
    }

    public void saveFile()
    {
        wdDocument.Save();
    }

    public bool isMarkExist()
    {
        string buff = text.Substring(startOfSearch);
        if (buff.Contains(beginOfSearchingMask))
            return true;
        else
            return false;
    }

    public string findAnyMark()
    {
        if (isMarkExist())
        {
            int startIndex = text.IndexOf(beginOfSearchingMask);
            int lengthOfword = 0;
            char checker = Convert.ToChar(beginOfSearchingMask);
            while (checker != Convert.ToChar(endOfSearchingMask))
            {
                checker = text[startIndex + lengthOfword]; //<asr>
                lengthOfword++;
            }
            lengthOfword++;
            int endIndex = startIndex + lengthOfword;
            object startPos = (object)startIndex;
            object endPos = (object)endIndex;
            wdRange = wdDocument.Range(ref startPos, ref endPos);
            return wdRange.Text;
        }
        return string.Empty;
    }

    public string getNextMark()
    {

        if (isMarkExist())
        {
            string buff = text.Substring(startOfSearch);
            int startIndex = buff.IndexOf(beginOfSearchingMask);
            int lengthOfWord = 0;
            char checker = Convert.ToChar(beginOfSearchingMask);
            while (checker != Convert.ToChar(endOfSearchingMask))
            {
                checker = buff[startIndex + lengthOfWord];
                if (checker != Convert.ToChar(endOfSearchingMask))
                    lengthOfWord++;
            }
            lengthOfWord++;
            int endIndex = startIndex + lengthOfWord;
            startOfSearch += endIndex;
            return buff.Substring(startIndex, lengthOfWord);
        }
        return string.Empty;
    }

    public List<string> getMarks()
    {
        List<string> textMarks = new List<string>();
        while (isMarkExist())
        {
            textMarks.Add(getNextMark());
        }
        return textMarks;
    }

    public void replaceMark(string textForSearching, string textForReplacement)
    {
        wdFind = wdApp.Selection.Find;
        wdFind.ClearFormatting();
        wdFind.Text = textForSearching;
        wdFind.Replacement.ClearFormatting();
        wdFind.Replacement.Text = textForReplacement;

        object replaceAll = Word.WdReplace.wdReplaceAll;
        wdFind.Execute(ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
            ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj,
            ref replaceAll, ref missingObj, ref missingObj, ref missingObj, ref missingObj);
    }

    public string getCatalog()
    {
        return wdDocument.Path;
    }


    public string GetMark()
    {
        wdFind = wdApp.Selection.Find;
        wdFind.ClearFormatting();
        wdFind.Text = "[" + beginOfSearchingMask + "]*[" + endOfSearchingMask + "]";
        wdFind.Replacement.ClearFormatting();
        wdFind.MatchWildcards = true;
        return wdFind.Execute().ToString();
    }

    public bool isExist()
    {
        wdFind = wdApp.Selection.Find;
        wdFind.ClearFormatting();
        wdFind.Text = "[" + beginOfSearchingMask + "]*[" + endOfSearchingMask + "]";
        wdFind.Replacement.ClearFormatting();
        wdFind.MatchWildcards = true;
        return wdFind.Execute();
    }

}
