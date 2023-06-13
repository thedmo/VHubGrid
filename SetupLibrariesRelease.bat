git submodule init
git submodule update
cd VideohubRoutingCli
mkdir build
cd build
cmake ..
cmake --build . --config Release --target install /O2