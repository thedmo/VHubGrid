git submodule init
git submodule update
cd VideohubRoutingCli
mkdir build
cd build
cmake ..
cmake --build . --config Debug --target install