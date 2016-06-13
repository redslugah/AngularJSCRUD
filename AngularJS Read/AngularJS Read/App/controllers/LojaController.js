angular.module("aplicacao").controller("Loja", function ($scope)
{
            $scope.loja = {
                Id: 1,
                Nome: "Loja do zé",
                Categoria: "bar",
                Numero: "532",
                Rua: "Barmatelo Luiz",
                Url: "https://media-cdn.tripadvisor.com/media/photo-s/06/26/f7/d8/bar-do-ze.jpg"
            }
            $scope.loja2 = {
                Id: 1,
                Nome: "loja do jão",
                Categoria: "bar",
                Numero: "287",
                Rua: "Maria das rosas",
                Url: ""
            }
            
        }
    );