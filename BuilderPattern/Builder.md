# Builder Pattern

### 概念
将一个复杂对象的构建于它的表示分离, 使得同样的构建过程可以创建不同的表示.

### 总结
* builder模式主要用于分步骤构建一个复杂的对象. 分步骤(构建房屋的过程)是一个稳定的算法, 复杂对象的各个部分(房子的各个组件)则经常变化.
* abstract factory模式解决系列对象的需求变化; builder模式解决对象部分的需求变化.

### 缺点
难以应对分步骤构建算法的需求变动