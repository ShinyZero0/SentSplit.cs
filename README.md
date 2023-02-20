# sharpjoin
## Intro

A pretty simple program that splits each paragraph (line) of given text by sentences and adds a blank line after.  
Of course, after that it can join all sequences of lines without blank lines into single strings (paragraphs) for pasting back in e.g. LibreOffice after editing in Vim.

## TODO:
- [x] Fix adding a whitespace after a paragraph
- [ ] Ignore some abbreviations e.g. e.g. after which the capitalized word will be on a new line

text.vim is for using as a custom formatter for [NeoFormat](https://github.com/sbdchd/neoformat).
Assumes you have sharpjoin in PATH

