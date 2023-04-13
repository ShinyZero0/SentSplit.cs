{
  description = "A very basic flake";

  inputs = {nixpkgs.url = "github:nixos/nixpkgs/nixos-unstable";};
  outputs = {
    self,
    nixpkgs,
  }: let
    system = "x86_64-linux";
    pkgs = nixpkgs.legacyPackages.${system};
  in {
    devShells.x86_64-linux.default = pkgs.mkShell {
      name = "SentSplit.cs";
      buildInputs = [
        pkgs.dotnet-sdk_7
        pkgs.clang
        pkgs.zlib
      ];
    };
  };
}
