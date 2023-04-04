function! neoformat#formatters#text#enabled() abort
    return ['Join', 'Split']
endfunction
function! neoformat#formatters#text#Split() abort
    return {
        \ 'exe': 'sentsplit',
        \ 'args': ['--split'],
        \ 'stdin': 0
        \ }
endfunction
function! neoformat#formatters#text#Join() abort
    return {
        \ 'exe': 'sentsplit',
        \ 'args': ['--join'],
        \ 'stdin': 0
        \ }
endfunction
