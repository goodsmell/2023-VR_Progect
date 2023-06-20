# 2023-VR_Project
2023년 1학기 혼합현실 팀프로젝트
<p align="center">
  <br>
  <img width="80%" src="https://github.com/JeongEon8/2023-VR_Project/assets/113885866/8772364c-dbd4-4874-87df-0495e82b9aba"/>
  <br>
</p>

## 프로젝트 소개

<p align="justify">
프로젝트 개요/동기
</p>

<p align="center">
 현대 사회에서 스트레스와 불안이 증가하면서 힐링을 위한 낚시와 힐링 게임의 인기가 증가하였다.<br>
 이 둘을 결합한 VR 낚시 게임을 제작하게 되었다.<br>
</p>

<br>

## 기술 스택

|   C#   |  Unity  |   Meta   |
| :----: | :-----: | :------: |
|<img width="30%" src="https://github.com/JeongEon8/2023-VR_Project/assets/113885866/9bae8459-6a6f-4381-b614-76b0cb10e67f"/>|<img width="80%" src="https://github.com/JeongEon8/2023-VR_Project/assets/113885866/5b729ac5-0aad-40be-a7e7-c4734bd34631"/>|<img width="50%" src="https://github.com/JeongEon8/2023-VR_Project/assets/113885866/52a156ea-e79c-46c5-bbff-dbf6e0fdbd85"/>|

<br>

## 구현 기능

### 기능 1 : 낚싯줄
<p align="justify">
Configurable Joints를 이용하여 각 큐브를 연결하여 줄을 구현하였다.
</p>

### 기능 2 : 물고기 이동
<p align="justify">
물고기가 영역 안에서 이동하도록 구현하고, 일정 영역을 벗어나면<br>
랜덤한 위치에서 리스폰 되도록 구현하였다.
</p>

### 기능 3 : 낚싯대 리스폰
<p align="justify">
낚싯대가 Seleted exited 하면 정해진 위치와 각도로 이동하여 리스폰한다.<br>
grab하고 있다가 놓치는 경우 소켓 블록에서 리스폰 한다.
</p>

### 기능 4 : 물고기 판매 + 배 업그레이드
<p align="justify">
물고기가 상자 콜라이더에 닿으면 100씩 증가하고, 물고기는 사라진다.<br>
각 스테이지 맞는 돈이 모이면 SceneChange 되어 더 좋은 배에서 낚시 할 수 있다.
</p>
<br>

## 배운 점 & 아쉬운 점

### 에셋부족 및 예산 없음
<p align="justify">
찌, 릴, 낚싯줄, 물고기 등의 무료 에셋이 없어 구현하기 어려움 부분이 있었다.<br>
또한 낚시대 업그레이드 기능, 물고기  종류마다 가격 다르게 측정하기를 계획하였으나 실천하지 못하였다.
</p>

### 기술 부족
<p align="justify">
유니티 기술이 부족하여 낚싯대의 릴과 물고기를 잡았을 때 사용자에게<br>
알려줄 수 있도록 하는 컨트롤러 햅틱 기능을 구현하지 못하였다.
</p>
<br>

## 라이센스

MIT &copy; [NoHack](mailto:jane043112@gmail.com)
