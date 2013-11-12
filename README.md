Huffman
=======

This is implementation of huffman algorithm in c#.

Usage
--

Here is example to use this library:
```C#

byte[] sourceBytes // Bytes which need to encoded

//encoding
byte[] encodedBytes = HuffmanEncoder.Encode(sourceBytes);

//decoding
byte[] sameWithSourceBytes = HuffmanEncoder.Decode(encodedBytes);

```

If you want, you can use the console application project which use huffman.dll for encoding/decoding files.
Use cmd for this...
```
>Huffman.Console.exe
[-e FILENAME] for encode file
[-d FILENAME] for decode *.huf file

>Huffman.Console.exe -e IMG_1278.JPG
working...
done.

>Huffman.Console.exe -d IMG_1278.JPG.huf
working...
done.
```
