# SentSplit
## Showcase

Let's say you have 3 paragraphs. They are pretty hard to edit in vim as they are long single lines.

![before](images/before.png)

How about pressing some key to split them to multiple lines by sentences?
Of course it can be reverted with another command.

![after](images/after.png)

## Description

A pretty simple program (maybe it even can be called formatter) that splits each paragraph (which are represented as lines when working in office suit) of given text by sentences and adds a blank line after.
After that it can join all sequences of lines without blank lines into single strings (paragraphs) for pasting back in e.g. LibreOffice after editing in Vim.

[text.vim](text.vim) 
is for using as a custom formatter for 
[NeoFormat](https://github.com/sbdchd/neoformat).
Assumes you have `sentsplit` in PATH.

## Building

Obviously requires dotnet core 7 (will most likely work with 6 and earlier).
Requires also: zlib-devel and clang, without it NativeAOT won't compile, but you can remove a NativeAOT line from [project file](SentSplit.csproj)
Just run `make pub` and grab the binary from `out` directory in project root
If you don't want to install these manually you can run `nix develop` and just `make pub` there. Flake packaging is WIP.

## Naming

At first i had a mapping to split a line into sentences with vim regex, so i planned to make a program to only join lines, but not split.
Later i realised it'd be cool to make it automatically format the whole file.

## TO DO:

- [ ] ReadAllLines => StreamReader and maybe stdin as it could be faster
- [ ] Ignore some abbreviations e.g. e.g. after which the capitalized word will be on a new line (hard to do with regex)
- [ ] Make flake package
- [x] .NET 6 => 7 
- [x] Fix adding a whitespace after a paragraph
