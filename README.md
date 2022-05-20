# BNR
业务流水号规则生成器

##  {CN:出库} 

 CN指令是获取冒号后面中文的拼音首字母      = CK

## {D:yyyyMMdd}

 D指令是获取当天时间按照冒号后面规则呈现 = 20220520

## {S:ORDER}

 S指令是 将冒号后面的内容作为固定字符      = ORDER

 ## {N:{S:ORDER}/00000000}

 N指令是将冒号后面的内容作为 计数的一个组,不同组单独计数 ,斜杠后面作为位数 =00000001 . 超时位数时长度自动增加.





## 举例

{S:OD}{CN:广州}{D:yyyyMM}{N:{S:ORDER}{CN:广州}{D:yyyyMM}/00000000}{N:{S:ORDER_SUB}{CN:广州}{D:yyyyMM}/00000000}

  ODGZ2016090029297200292972

{CN:广州}{D:yyyyMMdd}{N:{D:yyyyMMdd}/0000}{S:RJ}

  GZ20160913292971RJ





## 参考

https://github.com/beetlex-io/BNR
