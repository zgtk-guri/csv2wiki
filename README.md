# csv2wiki
A converter from CSV (Comma Separated Values) to MediaWiki table format

# Usage

Build with Visual Studio 2013 or later.

```
csv2wiki input-csv [output-wiki]
```

`input-csv` is the input CSV (Comma Separated Values) file path.
The line started with '#' will be ignored as a comment.

`output-wiki` is output Media-Wiki table format file path.
This parameter is optional.
If it is omitted, output file name is the same as input file name, and change its extention `.txt`.