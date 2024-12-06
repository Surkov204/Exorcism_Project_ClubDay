using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

    private static string[] wordList = {
    "algorithm", "variable", "function", "array",
    "loop", "conditional", "string", "class",
    "object", "inheritance", "polymorphism", "abstraction",
    "data", "structure", "queue", "stack",
    "tree", "linked", "database", "table",
    "record", "primary", "key", "foreign",
    "ip", "address", "domain", "protocol",
    "authentication", "encryption", "firewall", "malware",
    "kernel", "thread", "process", "multithreading",
    "api", "framework", "library", "syntax",
    "compile", "debug", "runtime", "exception",
    "instance", "method", "constructor", "parameter",
    "object-oriented", "interface", "event", "listener",
    "iteration", "recursion", "hash", "cache",
    "binary", "byte", "script", "source",
    "repository", "version", "control", "deployment",
    "continuous", "integration", "docker", "virtual",
    "machine", "cloud", "computing", "network",
    "bandwidth", "latency", "protocol", "subnet",
    "dns", "server", "client", "ssl",
    "framework", "bootstrap", "mvc", "html",
    "css", "javascript", "json", "xml",
    "query", "filter", "sort", "join",
    "normalization", "schema", "transaction", "acid"
};

    public static string GetRandomWord()
    { 
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}