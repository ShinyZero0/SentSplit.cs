# sharpjoin

## Showcase

Let's say you have 3 paragraphs. They are pretty hard to edit in vim as they are fat single lines.

![before](images/before.png)

How about pressing some key to split them to multiple lines by sentences?
Don't worry, it's reversible.

![after](images/after.png)

## Description

A pretty simple program (maybe i can even call it formatter) that splits each paragraph (line) of given text by sentences and adds a blank line after.

Of course, after that it can join all sequences of lines without blank lines into single strings (paragraphs) for pasting back in e.g. LibreOffice after editing in Vim.

[text.vim](text.vim) 
is for using as a custom formatter for 
[NeoFormat](https://github.com/sbdchd/neoformat).
Assumes you have sharpjoin in PATH.

## Naming

At first i had a mapping to split a line into sentences with vim regex, so i planned to make a program to only join lines, but not split.
Later i realised it'd be cool to make it automatically format the whole file a proper way.

## TO DO:

- [ ] ReadAllLines => StreamReader as it could be faster
- [ ] Ignore some abbreviations e.g. e.g. after which the capitalized word will be on a new line
- [x] .NET 6 => 7 
- [x] Fix adding a whitespace after a paragraph
