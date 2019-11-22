le_gusta_a(jose,maria).
le_gusta_a(maria,libro).
le_gusta_a(juan,coche).
le_gusta_a(jose,pescado).

sucesor(2,1).
sucesor(3,2).
sucesor(4,3).
sucesor(5,4).
sucesor(6,5).
sucesor(6,7).

amigos(pedro,antonio).
amigos(pedro,flora).
amigos(pedro,juan).
amigos(pedro,vicente).  
amigos(luis,felipe).
amigos(luis,maria).
amigos(luis,vicente).
amigos(carlos,paloma).
amigos(carlos,lucia).
amigos(carlos,juan).
amigos(carlos,vicente).
amigos(fernando,eva).
amigos(fernando,pedro).

millonario(pedro).
millonario(antonio).
millonario(flora).

soltero(pedro).
soltero(flora).
soltero(eva).
soltero(luis).


padre_de(carlos,fernando).
padre_de(antonio,maria).
padre_de(antonio,carlos).


arco(a,b).
arco(a,c).
arco(b,d).
arco(c,d).
arco(c,e).
arco(d,e).


cargar:-exists_file('ejemplo.bd'),consult('ejemplo.bd').
% amigos(X,vicente),amigos(X,Y),millonario(Y),soltero(Y).
amigos_solteros(X,Y):- amigos(X,vicente),amigos(X,Y),millonario(X),soltero(X),millonario(Y),soltero(Y).
amigos(X,Y).

legusta(pepe,pesca).
legusta(maria,bailar).
legusta(ana,pesca).
legusta(pepe,musica).
legusta(maria,musica).
legusta(ana,bailar).
