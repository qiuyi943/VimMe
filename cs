#!/bin/bash
echo "***************************************************"
echo "*                sjj0412                          *"
echo "***************************************************"
if [ $# -lt 1 ];then
    echo "please input rootdir"
    exit 1
fi
if [ ${1:0:1} != "/" ];then
        TARGET=${PWD}/${1}
    else
	TARGET=$1
fi
if [ -d $TARGET ];then
	echo "The path is"$TARGET
else
    echo "$TARGET" is no exist
    exit 1
fi
cd $TARGET
if [ "$2" != "-u" ] && [ -f "cscope.files" ];then
	echo "Files index is existed,you will use the exist index"
	echo "if you want to updata,please add -u option"
else
	echo "Files index is developing,please waiting"
rm -rf cscope.files
#find $TARGET -name '*.[chsS]' -print >>cscope.files
#find $TARGET -name '*.cpp' -print >>cscope.files
#find $TARGET -name '*.java' -print >>cscope.files
#ctags -L ./cscope.files
#ctags -R --sort=1 --c++-kinds=+p --fields=+iaS --extra=+q --language-force=C++ -f cpp .
ctags -R --c++-kinds=+p --fields=+iaS --extra=+q .
ctags -I __THROW --file-scope=yes --langmap=c:+.h --languages=c,c++ --links=yes --c-kinds=+p --fields=+S -R -f ~/.vim/systags /usr/include /usr/local/include
#cscope -Rkb
cscope -Rbq
fi
cd ~/.vim
rm  cscope.*
rm  tags
ln -s $TARGET/cscope.out cscope.out
ln -s $TARGET/cscope.in.out cscope.in.out
ln -s $TARGET/cscope.po.out cscope.po.out
ln -s $TARGET/tags tags
echo "**************************************************"
