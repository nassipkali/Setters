git clone https://github.com/linksplatform/conan-center-index
cd conan-center-index && git checkout only-development && cd recipes
conan create platform.interfaces/0.2.0+ platform.interfaces/0.2.5@ -pr=linksplatform
