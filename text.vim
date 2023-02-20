function! neoformat#formatters#text#enabled() abort
    return ['Join']
endfunction
function! neoformat#formatters#text#Join() abort
    return {
        \ 'exe': 'sharpjoin',
        \ 'args': [],
        \ 'stdin': 0
        \ }
endfunction
