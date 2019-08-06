# UnityRoundedShader
Rounded rectangle, circle shaders in Unity

![alt tag](https://github.com/sunduk/UnityRoundedShader/blob/master/screenshot.png?raw=true)

## Description
셰이더로 둥근 사각형을 만들기 위해 구글에 검색해 보니 아래 두개의 사이트가 상단에 보였습니다.

https://www.shadertoy.com/view/ldfSDj

https://github.com/Nobinator/Unity-UI-Rounded-Corners

하나는 Shadertoy라고 셰이더와 관련해서 아주 유명한 사이트입니다.

다른 하나는 github에 올라와 있는 곳인데 제가 구현하려는 모습과 흡사하여 많이 참고를 하였습니다.

저 코드에서는 엣지를 부드럽게 하기 위해 fwidth()라는 함수를 사용하였는데 사실 어떤 원리인지 정확히 이해가 안갔습니다.

그래서 제가 생각한 방식으로 다시 작성하였고 그 결과물을 여기에 올립니다.

더불어 원 모양을 만드는 셰이더도 추가로 만들었는데,

둥근 사각형을 만들어 보니 원 모양을 만드는것도 쉽게 응용이 가능했으며 활용도도 높을것 같아서 추가하였습니다.


-----


The below two web sites appeared when I searched on google.

https://www.shadertoy.com/view/ldfSDj

https://github.com/Nobinator/Unity-UI-Rounded-Corners


The first one is the Shadertoy which is very famous web site about shaders.

The second web site also gave me an idea to implement it.

I have read the shader codes which made by Nobinator, but I didn't understand full of it.

I was not cleared about fwidth() function in cg shader.

So, I have re-written the shader codes more understandable and added a circle shader.


## License
- 소스코드와 이미지는 아무런 제약 없이 자유롭게 사용 가능합니다.
- All source codes and images are free to use(Commercial use is possible).

/*
 * ------------------------------------------------------------
 * "THE BEERWARE LICENSE" (Revision 42):
 * I wrote this code. As long as you retain this 
 * notice, you can do whatever you want with this stuff. If we
 * meet someday, and you think this stuff is worth it, you can
 * buy me a beer in return.
 * ------------------------------------------------------------
 */
 
