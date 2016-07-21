#Vim configuration for C/C++ IDE

First of all, you should install the vim in your PC. For example, you run "sudo apt-get install vim" on Ubuntu to install the vim.

Second, you can download this repo and run "./install" to configure the vim env automatically.

Third, assume that there is folder of source code in ~/code_folder, run "cs ~/code_folder" to produce the tags and cscope.*.

Finnaly, you enter ~/code_folder and surf the code sea with running vim.

Some hotkeys youshould kown:

Ctrl+f: maps ":cs find" in command line
Ctrl+b: delelte the SPACE in tail of line
Ctrl+a: maps ":%s/SRC/DST/g" in command line to replace the SRC words with DST

Ctrl+m+s: ":cs find s curword" in command line
Ctrl+m+f: ":cs find f curword" in command line
Ctrl+m+g: ":cs find g curword" in command line
Ctrl+m+i: ":cs find i curword" in command line
Ctrl+m+d: ":cs find d curword" in command line
Ctrl+m+c: ":cs find c curword" in command line

,+w+m: split the window

